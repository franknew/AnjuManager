
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class LoginResult
    {
        public string token { get; set; }

        public UserEntireInfo User { get; set; }

        public List<Menu> Menu { get; set; }
    }
}
