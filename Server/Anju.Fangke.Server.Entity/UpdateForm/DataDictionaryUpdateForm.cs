using Anju.Fangke.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class DataDictionaryUpdateForm : SimpleUpdateForm<DataDictionary>
    {
        public DataDictionaryQueryForm DataDictionaryQueryForm { get; set; }
    }
}