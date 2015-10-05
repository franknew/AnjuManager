using Anju.Fangke.Server.Forms;
using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class LoginResponse : BaseResponse
    {
        public LoginResultForm Result { get; set; }
    }
}
