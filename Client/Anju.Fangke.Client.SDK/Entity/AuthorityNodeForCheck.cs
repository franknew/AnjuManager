using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class AuthorityNodeForCheck
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 显示用的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否选中，true为有权限，false为无权限
        /// </summary>
        public bool Checked { get; set; }
    }
}
