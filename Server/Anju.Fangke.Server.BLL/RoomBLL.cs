using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;

namespace Anju.Fangke.Server.BLL
{
    public class RoomBLL
    {
        public List<Room> Query(RoomQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            RoomDao dao = new RoomDao(mapper);
            return dao.Query(form);
        }

        public string Add(Room Room)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            RoomDao dao = new RoomDao(mapper);
            return dao.Add(Room);
        }

        public bool Update(Room Room)
        {
            if (string.IsNullOrEmpty(Room.ID))
            {
                throw new Exception("没有房间ID");
            }
            ISqlMapper mapper = MapperHelper.GetMapper();
            RoomDao dao = new RoomDao(mapper);
            return dao.Update(new RoomUpdateForm { Entity = Room, RoomQueryForm = new RoomQueryForm { ID = Room.ID } });
        }

        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("没有房间ID");
            }
            ISqlMapper mapper = MapperHelper.GetMapper();
            RoomDao dao = new RoomDao(mapper);
            return dao.Delete(new RoomQueryForm { ID = id });
        }
    }
}
