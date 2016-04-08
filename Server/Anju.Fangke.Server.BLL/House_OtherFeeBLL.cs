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
    public class House_OtherFeeBLL
    {
        public List<House_OtherFee> Query(House_OtherFeeQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            House_OtherFeeDao dao = new House_OtherFeeDao(mapper);
            return dao.Query(form);
        }

        public string Add(House_OtherFee ho)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            House_OtherFeeDao dao = new House_OtherFeeDao(mapper);
            return dao.Add(ho);
        }

        public bool Delete(House_OtherFeeQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            House_OtherFeeDao dao = new House_OtherFeeDao(mapper);
            return dao.Delete(form);
        }
    }
}
