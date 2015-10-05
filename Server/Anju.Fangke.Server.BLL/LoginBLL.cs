using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Forms;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;
using SOAFramework.Library.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;

namespace Anju.Fangke.Server.BLL
{
    public class LoginBLL
    {
        private ICache cache = CacheFactory.Create();

        public LoginResultForm Login(string username, string password)
        {
            LoginResultForm result = new LoginResultForm();
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao userdao = new UserDao(mapper);
            UserInfoDao userInfoDao = new UserInfoDao(mapper);
            RoleDao roleDao = new RoleDao(mapper);
            User_RoleDao urdao = new User_RoleDao(mapper);
            LogonHistoryDao historyDao = new LogonHistoryDao(mapper);
            var user = userdao.Query(new UserQueryForm { Name = username, Password = password }).FirstOrDefault();
            if (user != null)
            {
                if (user.Enabled == 0)
                {
                    throw new Exception("该用户已被禁用，请联系管理员！");
                }
                string token = Guid.NewGuid().ToString().Replace("-", "");
                var userinfo = userInfoDao.Query(new UserInfoQueryForm { ID = user.ID }).FirstOrDefault();
                UserFullInfo u = new UserFullInfo
                {
                    User = user,
                };
                if (userinfo != null)
                {
                    u.UserInfo = userinfo;
                }
                var ur = urdao.Query(new User_RoleQueryForm { UserID = user.ID });
                List<string> roleidlist = new List<string>();
                ur.ForEach(t =>
                {
                    roleidlist.Add(t.RoleID);
                });

                var roles = roleDao.Query(new RoleQueryForm { Ids = roleidlist });
                u.Roles = roles;

                CacheItem item = new CacheItem(token, u);
                LogonHistory history = new LogonHistory
                {
                    LogonTime = DateTime.Now,
                    Token = token,
                    UserID = user.ID,
                    ActiveTime = DateTime.Now,
                };
                historyDao.Add(history);
                result.User = u;
                result.token = token;
                cache.AddItem(item, 30 * 60);
                return result;
            }
            else
            {
                throw new Exception("用户名或者密码错误！请输入正确的用户名和密码！");
            }
        }
    }
}
