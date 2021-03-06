using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.DAL
{
    public partial class UserDao : SimpleDao<User, UserQueryForm, UserUpdateForm>
    {
        public UserDao(ISqlMapper mapper)
            : base(mapper)
        {
        }
        
        public UserDao()
            : base(null)
        {
        }
        
        public DateTime? QueryMaxLastUpdateTime()
        {
            return Mapper.QueryForObject<DateTime?>("QueryUserLastUpdateTime", null);
        }
    }
}