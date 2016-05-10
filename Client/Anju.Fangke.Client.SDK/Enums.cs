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
        计数收费 = 1,
        固定收费 = 2,

    }

    public enum CycleType
    {
        月 = 1,
        季度 = 2,
        年 = 3,
    }

    public enum HouseType
    {
        托管 = 1,
        可租 = 2,
        可售 = 3,
        我租 = 4,
        我售 = 5,
        租售 = 6,
        已租 = 7,
        已售 = 8,
        被成交 = 9,
        暂缓 = 10
    }

    public enum DecorationType
    {
        毛坯 = 1,
        简装 = 2,
        精装 = 3,
        豪装 = 4,
    }

    public enum DataAccessType
    {
        所有数据 = 1,
        自己及子级数据 = 2,
    }
}