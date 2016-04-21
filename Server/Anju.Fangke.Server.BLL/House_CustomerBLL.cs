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
    public class House_CustomerBLL
    {
        public List<House_Customer> Query(House_CustomerQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            House_CustomerDao dao = new House_CustomerDao(mapper);
            return dao.Query(form);
        }

        public bool Delete(House_CustomerQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            House_CustomerDao dao = new House_CustomerDao(mapper);
            return dao.Delete(form);
        }

        public string Add(House_Customer hc)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            House_CustomerDao dao = new House_CustomerDao(mapper);
            return dao.Add(hc);
        }
    }
}
