﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Model
{
    public class UserFullInfo
    {
        public FullUser User { get; set; }

        public List<Role> Roles { get; set; }
    }
}
