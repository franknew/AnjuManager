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

namespace Anju.Fangke.Client.Forms
{
    public partial class LogonHistoryManagement : ChildForm
    {
        public LogonHistoryManagement()
        {
            InitializeComponent();
            pager.Paging += Pager_Paging;
        }

        private void Pager_Paging(object sender, SOAFramework.Client.Controls.Pager.PagingEventArgs e)
        {
            PagingQuery(e.CurrentPageIndex);
        }

        private void LogonHistoryManagement_Shown(object sender, EventArgs e)
        {
            dtActiveTime_End.Value = dtActiveTime_Start.Value = dtLogonTime_End.Value = dtLogonTime_Start.Value = DateTime.Now;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            PagingQuery(1);
        }

        private void PagingQuery(int index)
        {
            pager.CurrentPageIndex = index;
            QueryLogonHistoryRequest request = new QueryLogonHistoryRequest();
            request.form = new LogonHistoryQueryForm();
            request.token = this.Token;
            request.form.UserName = string.IsNullOrEmpty(txbUserName.Text) ? null : txbUserName.Text;
            request.form.PageSize = pager.PageSize;
            request.form.CurrentIndex = pager.CurrentPageIndex;
            if (chkActiveTime.Checked)
            {
                request.form.ActiveTime_Start = (DateTime)dtActiveTime_Start.CollectBindingData();
                request.form.ActiveTime_End = (DateTime)dtActiveTime_End.CollectBindingData();
            }
            if (chkLogonTime.Checked)
            {
                request.form.LogonTime_End = (DateTime)dtLogonTime_End.CollectBindingData();
                request.form.LogonTime_Start = (DateTime)dtLogonTime_Start.CollectBindingData();
            }
            SDKSync<QueryLogonHistoryResponse>.CreateInstance(this).Execute(request, Query_Callback);
        }

        private void Query_Callback(QueryLogonHistoryResponse response)
        {
            dgvList.DataSource = response.Data.Record;
            pager.RecordCount = response.Data.RecordCount;
        }

        private void chkLogonTime_CheckedChanged(object sender, EventArgs e)
        {
            dtLogonTime_End.Enabled = dtLogonTime_Start.Enabled = chkLogonTime.Checked;
        }

        private void chkActiveTime_CheckedChanged(object sender, EventArgs e)
        {
            dtActiveTime_End.Enabled = dtActiveTime_Start.Enabled = chkActiveTime.Checked;
        }
    }
}
