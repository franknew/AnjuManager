using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class DataDictionaryResult
    {
        public DataDictionaryGroup Group { get; set; }

        public List<DataDictionary> Items { get; set; }
    }
}
