using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;
using SOAFramework.Library.Cache;
using SOAFramework.Service.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using SOAFramework.Library;
using DreamWorkflow.Engine;
using SOAFramework.Service.Core;

namespace Anju.Fangke.Server.BLL
{
    public class UserBLL
    {
        private ICache cache = CacheFactory.Create();

        public List<FullUser> Query(FullUserQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            User_RoleDao urdao = new User_RoleDao(mapper);
            RoleDao roledao = new RoleDao(mapper);
            var users = dao.QueryFullUser(form);
            var userids = (from u in users select u.ID).ToList();
            var urs = urdao.Query(new User_RoleQueryForm { UserIDs = userids });
            var roleids = (from ur in urs select ur.RoleID).Distinct().ToList();
            var roles = roledao.Query(new RoleQueryForm { IDs = roleids });
            foreach (var u in users)
            {
                u.Roles = (from ur in urs join role in roles on ur.RoleID equals role.ID
                           where ur.UserID.Equals(u.ID) select role).ToList();
            }
            return users;
        }

        public List<FullUser> SimpleQuery(FullUserQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            return dao.QueryFullUser(form);
        }

        public int QueryCount(FullUserQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            return dao.QueryFullUserCount(form);
        }

        public string Add(User user, UserInfo ui, List<Role> roles)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            UserInfoDao uidao = new UserInfoDao(mapper);
            User_RoleDao urdao = new User_RoleDao(mapper);

            string id = dao.Add(user);
            if (ui != null)
            {
                ui.ID = id;
                uidao.Add(ui);
            }
            if (roles != null)
            {
                foreach (var role in roles)
                {
                    urdao.Add(new User_Role { UserID = id, RoleID = role.ID });
                }
            }
            return id;
        }

        public bool Update(User user, UserInfo ui, List<Role> roles)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            UserInfoDao uidao = new UserInfoDao(mapper);
            User_RoleDao urdao = new User_RoleDao(mapper);
            var updateuser = GetUserFormCache();
            dao.Update(new UserUpdateForm
            {
                Entity = new User
                {
                    Enabled = user.Enabled,
                    LastUpdateTime = DateTime.Now,
                    LastUpdator = updateuser?.User.ID,
                },
                UserQueryForm = new UserQueryForm { ID = user.ID }
            });
            if (ui != null)
            {
                if (uidao.Query(new UserInfoQueryForm { ID = user.ID }).FirstOrDefault() == null)
                {
                    ui.ID = user.ID;
                    uidao.Add(ui);
                }
                else
                {
                    uidao.Update(new UserInfoUpdateForm
                    {
                        Entity = ui,
                        UserInfoQueryForm = new UserInfoQueryForm { ID = user.ID }
                    });
                }
            }
            urdao.Delete(new User_RoleQueryForm { UserID = user.ID });
            if (roles != null)
            {
                foreach (var role in roles)
                {
                    urdao.Add(new User_Role { UserID = user.ID, RoleID = role.ID });
                }
            }
            return true;
        }

        public bool Delete(UserQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            dao.Update(new UserUpdateForm
            {
                Entity = new User { IsDeleted = 1 },
                UserQueryForm = form,
            });
            return true;
        }

        public bool ChangePassword(string username, string newpassword)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            var user = dao.Query(new UserQueryForm { Name = username }).FirstOrDefault();
            if (user == null)
            {
                throw new Exception(string.Format("用户名：{0}不存在！", username));
            }
            if (user.Enabled == 0)
            {
                throw new Exception(string.Format("用户名：{0}已被禁用！", username));
            }
            dao.Update(new UserUpdateForm
            {
                Entity = new User
                {
                    Password = newpassword
                },
                UserQueryForm = new UserQueryForm { ID = user.ID }
            });
            return true;
        }

        public bool ChangeSelfPassword(string oldpassword, string password)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            var user = GetUserFormCache();
            var u = dao.Query(new UserQueryForm { ID = user.User.ID, Password = oldpassword }).FirstOrDefault();
            if (u == null)
            {
                throw new Exception(string.Format("旧密码错误！"));
            }
            dao.Update(new UserUpdateForm
            {
                Entity = new User { Password = password },
                UserQueryForm = new UserQueryForm { ID = user.User.ID }
            });
            return true;
        }

        public UserFullInfo GetUserFormCache(string token = null)
        {
            if (string.IsNullOrEmpty(token))
            {
                token = ServiceSession.Current.Context.Parameters["token"].ToString();
            }
            CacheItem item = cache.GetItem(token);
            if (item == null)
            {
                return null;
            }
            UserFullInfo u = item.Value as UserFullInfo;
            return u;
        }

        public UserEntireInfo GetCurrentUser(string token = null)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            if (string.IsNullOrEmpty(token)) token = ServiceSession.Current.Context.Parameters["token"].ToString();
            var u = GetUserEntireInfoFromCache(token);
            if (u == null)
            {
                MonitorCache.GetInstance().PushMessage(new CacheMessage { Message = "user is null" }, SOAFramework.Library.CacheEnum.FormMonitor);
                UserDao userdao = new UserDao(mapper);
                RoleDao roledao = new RoleDao(mapper);
                UserInfoDao uidao = new UserInfoDao(mapper);
                LogonHistoryDao lhdao = new LogonHistoryDao(mapper);
                var logonhistory = lhdao.Query(new LogonHistoryQueryForm { Token = token }).FirstOrDefault();
                if (logonhistory == null) throw new Exception("获取当前用户信息时发生错误，用户不存在");
                string userid = logonhistory.UserID;
                var user = userdao.Query(new UserQueryForm { ID = userid }).FirstOrDefault();
                var userinfo = uidao.Query(new UserInfoQueryForm { ID = userid }).FirstOrDefault();
                var roles = roledao.QueryRoleByUserID(userid);
                u = new UserEntireInfo
                {
                    User = user,
                    Role = roles,
                    UserInfo = userinfo,
                };
            }
            return u;
        }

        public UserEntireInfo GetUserEntireInfoFromCache(string token)
        {
            var item = cache.GetItem(token);
            UserEntireInfo u = null;
            if (item != null) u = item.Value as UserEntireInfo;
            return u;
        }

        public int CheckUserAuth(string token)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            //验证有没有登录
            UserEntireInfo user = GetUserEntireInfoFromCache(token);

            //MonitorCache.GetInstance().PushMessage(new CacheMessage { Message = "check token:" + token }, SOAFramework.Library.CacheEnum.FormMonitor);
            if (user == null) return 3;
            LogonHistoryDao logonhistorydao = new LogonHistoryDao(mapper);
            var logonList = logonhistorydao.Query(new LogonHistoryQueryForm { Token = token });
            //登录超时
            if (logonList.Count == 0 || DateTime.Now - logonList[0].ActiveTime > new TimeSpan(0, 30, 0)) return 3;
            logonhistorydao.Update(new LogonHistoryUpdateForm
            {
                Entity = new LogonHistory { ActiveTime = DateTime.Now },
                LogonHistoryQueryForm = new LogonHistoryQueryForm { ID = logonList[0].ID },
            });
            if (ServiceSession.Current != null) return CheckAuth(user.Role);
            return -1;
        }

        public int CheckAuth(List<Role> roles)
        {
            //验证有没有权限访问
            var attr = ServiceSession.Current.Method.GetCustomAttribute<BaseActionAttribute>(true);
            if (attr != null)
            {
                ISqlMapper mapper = MapperHelper.GetMapper();
                string actionName = attr.Action;
                var servicelayer = ServiceSession.Current.Method.DeclaringType.GetCustomAttribute<ServiceLayer>(true);
                if (servicelayer != null)
                {
                    string moduleName = servicelayer.Module;
                    var modules = TableCacheHelper.GetDataFromCache<Module>(typeof(ModuleDao));
                    var actions = TableCacheHelper.GetDataFromCache<Model.Action>(typeof(ActionDao));
                    Role_Module_ActionDao dao = new Role_Module_ActionDao(mapper);
                    var module = modules.Find(t => t.Name == moduleName);
                    var action = actions.Find(t => t.Name == actionName);
                    if (module == null || action == null) return -1;
                    string actionID = action.ID;
                    string moduleID = module.ID;
                    Role_Module_ActionQueryForm query = new Role_Module_ActionQueryForm
                    {
                        ActionID = actionID,
                        ModuleID = moduleID
                    };
                    //MonitorCache.GetInstance().PushMessage(new CacheMessage { Message = "action id:" + actionID + ";module id:" + moduleID }, SOAFramework.Library.CacheEnum.FormMonitor);
                    var role_module_action = dao.Query(query);
                    bool hasRight = false;
                    foreach (var item in role_module_action)
                    {
                        if (roles != null && roles.Exists(t => t.ID == item.RoleID))
                        {
                            hasRight = true;
                            break;
                        }
                    }
                    if (!hasRight) return 4;
                }
            }
            return -1;
        }

        public string GetCurrentUserID()
        {
            var u = GetCurrentUser();
            if (u == null) throw new Exception("获取当前用户信息时发生错误，用户不存在");
            return u.User?.ID;
        }
    }
}
