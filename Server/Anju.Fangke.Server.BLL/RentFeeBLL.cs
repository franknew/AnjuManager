using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;

namespace Anju.Fangke.Server.BLL
{
    public class RentFeeBLL
    {
        public string Add(RentFee fee)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            RentFeeDao dao = new RentFeeDao(mapper);
            return dao.Add(fee);
        }

        public List<RentFee> Query(RentFeeQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            RentFeeDao dao = new RentFeeDao(mapper);
            return dao.Query(form);
        }

        public bool Update(RentFee fee)
        {
            if (string.IsNullOrEmpty(fee.ID)) throw new Exception("房租ID不能为空");
            ISqlMapper mapper = MapperHelper.GetMapper();
            RentFeeDao dao = new RentFeeDao(mapper);
            return dao.Update(new RentFeeUpdateForm
            {
                Entity = fee,
                RentFeeQueryForm = new RentFeeQueryForm { ID = fee.ID },
            });
        }
    }
}
