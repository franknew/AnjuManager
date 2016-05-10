using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class FullRoleInfo : Role
    {
        /// <summary>
        /// 父角色名称
        /// </summary>
        public string ParentRoleName { get; set; }

        /// <summary>
        /// 权限列表
        /// </summary>
        public List<AuthorityNodeForCheck> Authority { get; set; }

        public List<Menu> Menus { get; set; }

        public string DataAccessTypeName
        {
            get
            {
                string text = "";
                if (!DataAccessType.HasValue) return text;
                text = Enum.GetName(typeof(DataAccessType), DataAccessType);
                return text;
            }
        }
    }
}
