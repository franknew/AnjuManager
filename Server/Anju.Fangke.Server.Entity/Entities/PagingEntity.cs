using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{ 
    public class PagingEntity<T>  
    {
        public int RecordCount { get; set; }

        public int PageCount { get; set; }

        public List<T> Record { get; set; }
    }
}
