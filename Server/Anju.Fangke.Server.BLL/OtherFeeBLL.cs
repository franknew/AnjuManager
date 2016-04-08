using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using DreamWorkflow.Engine;
using IBatisNet.DataMapper;

namespace Anju.Fangke.Server.BLL
{
    public class OtherFeeBLL
    {
        public List<OtherFee> Query(OtherFeeQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            OtherFeeDao dao = new OtherFeeDao(mapper);
            return dao.Query(form);
        }
    }
}
