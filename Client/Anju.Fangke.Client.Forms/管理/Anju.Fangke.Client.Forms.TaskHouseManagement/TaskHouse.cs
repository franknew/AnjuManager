using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anju.Fangke.Client.SDK;
using SOAFramework.Client.Controls;
using SOAFramework.Client.Forms;
using SOAFramework.Library;

namespace Anju.Fangke.Client.Forms
{
    public partial class TaskHouse : BaseTakeHouse
    {
        public TaskHouse()
        {
            InitializeComponent();
        }

        public event EventHandler Take_Callback;

        private void btnSave_Click(object sender, EventArgs e)
        {
            var house = House.Clone();
            this.CollectData(house);
            TakeHouseRequest request = new TakeHouseRequest();
            request.house = house;
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, Save_Callback);
        }

        private void Save_Callback(CommonResponse response)
        {
            this.CollectData(House);
            if (Take_Callback != null) Take_Callback.Invoke(House, null);
            SOAFramework.Client.Controls.MessageBox.Show(this, "收房成功");
            this.Close();
        }
    }
}
