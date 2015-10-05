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
    public partial class User_RoleDao : BaseDao<User_Role, User_RoleQueryForm, User_RoleUpdateForm>
    {
        public User_RoleDao(ISqlMapper mapper)
            : base(mapper)
        {
        }
        
        public User_RoleDao()
            : base(null)
        {
        }
        
    }
}