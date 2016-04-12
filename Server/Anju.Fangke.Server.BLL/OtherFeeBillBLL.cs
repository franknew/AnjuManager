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
    public class OtherFeeBillBLL
    {
        public List<OtherFeeBill> Query(OtherFeeBillQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            OtherFeeBillDao dao = new OtherFeeBillDao(mapper);
            return dao.Query(form);
        }

        public string Add(OtherFeeBill bill)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            OtherFeeBillDao dao = new OtherFeeBillDao(mapper);
            return dao.Add(bill);
        }
    }
}
