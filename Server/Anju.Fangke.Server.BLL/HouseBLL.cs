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
    public class HouseBLL
    {
        public List<House> Query(HouseQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            HouseDao dao = new HouseDao(mapper);
            return dao.Query(form);
        }

        public string Add(House House)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            HouseDao dao = new HouseDao(mapper);
            return dao.Add(House);
        }

        public bool Update(House House)
        {
            if (string.IsNullOrEmpty(House.ID))
            {
                throw new Exception("没有套房ID");
            }
            ISqlMapper mapper = MapperHelper.GetMapper();
            HouseDao dao = new HouseDao(mapper);
            return dao.Update(new HouseUpdateForm { Entity = House, HouseQueryForm = new HouseQueryForm { ID = House.ID } });
        }

        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("没有套房ID");
            }
            ISqlMapper mapper = MapperHelper.GetMapper();
            HouseDao dao = new HouseDao(mapper);
            return dao.Delete(new HouseQueryForm { ID = id });
        }
    }
}
