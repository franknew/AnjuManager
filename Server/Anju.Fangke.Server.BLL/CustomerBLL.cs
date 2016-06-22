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
    public class CustomerBLL
    {
        public List<Customer> Query(CustomerQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            CustomerDao dao = new CustomerDao(mapper);
            return dao.Query(form);
        }

        public int QueryCount(CustomerQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            CustomerDao dao = new CustomerDao(mapper);
            return dao.QueryCount(form);
        }

        public List<Customer> QueryFullCustomer(FullCustomerQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            CustomerDao dao = new CustomerDao(mapper);
            return dao.QueryFullCustomer(form);
        }

        public int QueryFullCustomerCount(FullCustomerQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            CustomerDao dao = new CustomerDao(mapper);
            return dao.QueryFullCustomerCount(form);
        }

        public string Add(Customer customer)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            CustomerDao dao = new CustomerDao(mapper);
            return dao.Add(customer);
        }

        public bool Update(CustomerUpdateForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            CustomerDao dao = new CustomerDao(mapper);
            return dao.Update(form);
        }

        public bool Delete(CustomerQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            CustomerDao dao = new CustomerDao(mapper);
            return dao.Delete(form);
        }
    }
}
