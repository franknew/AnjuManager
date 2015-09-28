using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBatisNet.DataMapper;
using SOAFramework.Service.Core.Model;

namespace Anju.Fangke.Server.BLL
{
    public class MapperHelper
    {
        public static ISqlMapper GetMapper()
        {
            ISqlMapper mapper = null;
            if (ServiceSession.Current != null && ServiceSession.Current.Context.Parameters.ContainsKey("_Mapper"))
            {
                mapper = ServiceSession.Current.Context.Parameters["_Mapper"] as ISqlMapper;
            }
            else
            {
                mapper = Mapper.Instance();
            }
            return mapper;
        }
    }
}
