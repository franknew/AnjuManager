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
    public partial class ActionDao : SimpleDao<Action, ActionQueryForm, ActionUpdateForm>
    {
        public ActionDao(ISqlMapper mapper)
            : base(mapper)
        {
        }
        
        public ActionDao()
            : base(null)
        {
        }
        
        public DateTime? QueryMaxLastUpdateTime()
        {
            return Mapper.QueryForObject<DateTime?>("QueryActionLastUpdateTime", null);
        }
    }
}