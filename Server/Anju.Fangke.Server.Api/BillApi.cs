using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;

namespace Anju.Fangke.Server.Api
{
    [AuthFilter]
    public class BillApi
    {
        BillBLL bll = new BillBLL();
        
        public DataTable Query(QueryFullBillServiceForm form)
        {
            return bll.QueryFullBill(form);
        }

        public int GenerateBill()
        {
            UserBLL userbll = new UserBLL();
            return bll.GenerateBill(userbll.GetCurrentUser()?.User?.ID);
        }

        public BillModel QuerySingleBill(string BillID)
        {
            return bll.QuerySingle(BillID);
        }

        public bool Update(BillModel Bill)
        {
            return bll.Update(Bill);
        }
    }
}
