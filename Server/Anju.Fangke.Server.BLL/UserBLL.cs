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

        public bool Delete(List<string> ids)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            UserInfoDao uidao = new UserInfoDao(mapper);
            dao.Delete(new UserQueryForm { Ids = ids });
            uidao.Delete(new UserInfoQueryForm { Ids = ids });
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
    }
}
