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
    public partial class UserInfoDao : BaseDao<UserInfo, UserInfoQueryForm, UserInfoUpdateForm>
    {
        public UserInfoDao(ISqlMapper mapper)
            : base(mapper)
        {
        }
        
        public UserInfoDao()
            : base(null)
        {
        }
        
    }
}