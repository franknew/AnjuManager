using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.DAL
{
    public partial class LogonHistoryDao : BaseDao<LogonHistory, LogonHistoryQueryForm, LogonHistoryUpdateForm>
    {
        public LogonHistoryDao(ISqlMapper mapper)
            : base(mapper)
        {
        }
        
        public LogonHistoryDao()
            : base(null)
        {
        }
        
    }
}