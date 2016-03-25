using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Anju.Fangke.Server.Model
{
    public class AuthorityItem
    {
        [XmlAttribute]
        public string ActionID { get; set; }

        [XmlAttribute]
        public string ModuleID { get; set; }
    }
}
