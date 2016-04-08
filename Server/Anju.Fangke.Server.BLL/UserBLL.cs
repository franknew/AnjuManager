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

namespace Anju.Fangke.Server.BLL
{
    public class UserBLL
    {
        private ICache cache = CacheFactory.Create();

        public List<FullUser> Query(FullUserQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            return dao.QueryFullUser(form);
        }

        public string Add(User user, UserInfo ui)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            UserInfoDao uidao = new UserInfoDao(mapper);

            string id = dao.Add(user);
            if (ui != null)
            {
                ui.ID = id;
                uidao.Add(ui);
            }
            return id;
        }

        public bool Update(User user, UserInfo ui)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            UserInfoDao uidao = new UserInfoDao(mapper);
            var updateuser = GetUserFormCache();
            dao.Update(new UserUpdateForm
            {
                Entity = new User
                {
                    Enabled = user.Enabled,
                    LastUpdateTime = DateTime.Now,
                    LastUpdator = updateuser.User.ID,
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
            if (string.IsNullOrEmpty(token))
            {
                token = ServiceSession.Current.Context.Parameters["token"].ToString();
            }
            var u = GetUserEntireInfoFromCache(token);
            if (u == null)
            {
                MonitorCache.GetInstance().PushMessage(new CacheMessage { Message = "user is null" }, SOAFramework.Library.CacheEnum.FormMonitor);
                UserDao userdao = new UserDao(mapper);
                RoleDao roledao = new RoleDao(mapper);
                UserInfoDao uidao = new UserInfoDao(mapper);
                LogonHistoryDao lhdao = new LogonHistoryDao(mapper);
                var logonhistory = lhdao.Query(new LogonHistoryQueryForm { Token = token }).FirstOrDefault();
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
    }
}
