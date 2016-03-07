using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Client.SDK
{
    public class House : SimpleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string BuildingID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Floor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? RoomCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? HallCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? ToiletCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? RentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? RoomNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? HallNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? ToiletNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? KitchenNumber { get; set; }

    }
}
