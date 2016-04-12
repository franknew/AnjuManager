using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public enum RentType
    {
        合租 = 0,
        整租 = 1,
    }

    public enum FeeType
    {
        计数收费=1,
        固定收费=2,
        
    }

    public enum CycleType
    {
        月 = 1,
        季度 = 2,
        年 = 3,
    }
}