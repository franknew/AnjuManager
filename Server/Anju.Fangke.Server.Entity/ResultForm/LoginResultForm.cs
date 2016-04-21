using Anju.Fangke.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Forms
{
    public class LoginResultForm
    {
        public string token { get; set; }

        public UserEntireInfo User { get; set; }

        public List<Menu> Menu { get; set; }
    }
}
