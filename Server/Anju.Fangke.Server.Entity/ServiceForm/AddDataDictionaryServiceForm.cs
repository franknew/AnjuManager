using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.Model;

namespace Anju.Fangke.Server.Form
{
    public class AddDataDictionaryServiceForm
    {
        public DataDictionaryGroup Group { get; set; }

        public List<DataDictionary> Items { get; set; }
    }
}
