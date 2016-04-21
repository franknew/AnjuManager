using Anju.Fangke.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class House_CustomerUpdateForm : BaseUpdateForm<House_Customer>
    {
        public House_CustomerQueryForm House_CustomerQueryForm { get; set; }
    }
}