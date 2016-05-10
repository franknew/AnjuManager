using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anju.Fangke.Client
{
    public class MenuHandler
    {
        public void Close(Form form)
        {
            form.Close();
        }

        public void Relogin(Form form)
        {
            Application.Restart();
        }

        public void ChangeSelfPassword(Form form)
        {

        }
    }
}
