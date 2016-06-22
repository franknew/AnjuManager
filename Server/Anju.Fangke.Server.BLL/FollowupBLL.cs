using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;

namespace Anju.Fangke.Server.BLL
{
    public class FollowupBLL
    {
        public List<Followup> Query(FollowupQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            FollowupDao dao = new FollowupDao(mapper);
            return dao.Query(form);
        }

        public string Add(Followup form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            FollowupDao dao = new FollowupDao(mapper);
            return dao.Add(form);
        }

        public bool Delete(FollowupQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            FollowupDao dao = new FollowupDao(mapper);
            return dao.Delete(form);
        }

        public List<Followup> QueryFullFollowup(FullFollowupQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            FollowupDao dao = new FollowupDao(mapper);
            return dao.QueryFullFollowup(form);
        }

        public int QueryFullFollowupCount(FullFollowupQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            FollowupDao dao = new FollowupDao(mapper);
            return dao.QueryFullFollowupCount(form);
        }
    }
}
