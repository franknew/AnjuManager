using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class PagingEntity<T>
    {
        public int RecordCount { get; set; }

        public List<T> Record { get; set; }
    }
}
