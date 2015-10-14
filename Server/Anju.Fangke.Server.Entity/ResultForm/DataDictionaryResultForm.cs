using Anju.Fangke.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Form
{
    public class DataDictionaryResultForm
    {
        public DataDictionaryGroup Group { get; set; }

        public List<DataDictionary> Items { get; set; }
    }
}
