using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Api
{
    [AuthFilter]
    public class DataDictionaryApi
    {
        private DataDictionaryBLL bll = new DataDictionaryBLL();
        
        public List<DataDictionaryResultForm> QueryByGroupName(List<string> nameList)
        {
            return bll.QueryByGroupName(nameList);
        }

        public bool Add(AddDataDictionaryServiceForm form)
        {
            bll.AddGroup(form.Group);
            bll.AddItems(form.Items);
            return true;
        }
    }
}
