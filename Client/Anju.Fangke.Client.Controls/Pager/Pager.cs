using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOAFramework.Client.Controls.Pager
{
    public partial class Pager : UserControl, IServiceBindable
    {
        public Pager()
        {
            InitializeComponent();
        }

        #region properties
        private int currentPageIndex = 1;

        private int pageSize = 20;

        private int totalRecordCount = 0;

        private int pageGroupSize = 10;

        [Category(ControlCategory.Category)]
        [DefaultValue(20)]
        public int PageSize
        {
            get
            {
                return pageSize;
            }

            set
            {
                pageSize = value;
                txbPageSize.Text = value.ToString();
            }
        }


        [Browsable(false)]
        public int CurrentPageIndex
        {
            get
            {
                return currentPageIndex;
            }

            set
            {
                currentPageIndex = value;
                txbCurrentPageIndex.Text = value.ToString();
            }
        }

        [Browsable(false)]
        public int RecordCount
        {
            get
            {
                return totalRecordCount;
            }

            set
            {
                totalRecordCount = value;
                txbRecordCount.Text = value.ToString();
                if (!DesignMode) this.Render();
            }
        }

        [Browsable(false)]
        public int PageCount
        {
            get
            {
                int count = 0;
                if (pageSize <= 0 || RecordCount <= 0) return 0;
                if (RecordCount % pageSize == 0) count = RecordCount / pageSize;
                else count = RecordCount / pageSize + 1;
                return count;
            }
        }

        [Browsable(false)]
        public int StartIndex
        {
            get
            {
                int startindex = -1;
                if (pageSize <= 0 || currentPageIndex <= 0) return -1;
                startindex = pageSize * (currentPageIndex - 1);
                return startindex;
            }
        }

        [Browsable(false)]
        public int EndIndex
        {
            get
            {
                int endindex = -1;
                if (pageSize <= 0 || currentPageIndex <= 0) return -1;
                endindex = pageSize * currentPageIndex - 1;
                return endindex;
            }
        }

        [Category(ControlCategory.Category)]
        [DefaultValue(10)]
        public int PageGroupSize
        {
            get
            {
                return pageGroupSize;
            }

            set
            {
                pageGroupSize = value;
            }
        }

        [Browsable(false)]
        public int PageGroupCount
        {
            get
            {
                int count = 0;
                if (PageCount <= 0) return 0;
                if (PageCount % pageGroupSize == 0) count = PageCount / pageGroupSize;
                else count = PageCount / pageGroupSize + 1;
                return count;
            }
        }

        
        [Category(ControlCategory.Category)]
        public string CurrentPageIndexBindingRequestPropertyName
        {
            get { return txbCurrentPageIndex.BindingRequestPropertyName; }
            set { txbCurrentPageIndex.BindingRequestPropertyName = value; }
        }

        [Category(ControlCategory.Category)]
        public string PageSizeBindingRequestPropertyName
        {
            get { return txbPageSize.BindingRequestPropertyName; }
            set { txbPageSize.BindingRequestPropertyName = value; }
        }
        #endregion

        #region service binding property
        private string controlBindingPropertyName = "RecordCount";

        [Category(ControlCategory.Category)]
        [DefaultValue("RecordCount")]
        public string BindingControlPropertyName
        {
            get
            {
                return controlBindingPropertyName;
            }

            set
            {
                controlBindingPropertyName = value;
            }
        }

        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        [Browsable(false)]
        public string BindingRequestPropertyName { get; set; }

        [Category(ControlCategory.Category)]
        [DefaultValue(false)]
        [Browsable(false)]
        public bool Bindable { get; set; }

        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string BindingResponsePropertyName { get; set; }

        public object CollectBindingData()
        {
            return null;
        }
        #endregion

        #region event handler
        public event PagingEventHandler Paging;
        #endregion

        #region action
        public void Render()
        {
            pnlPages.Controls.Clear();
            if (pageSize <= 0 || currentPageIndex <= 0) return;
            lblRecordCount.Text = RecordCount.ToString();
            lblPageCount.Text = PageCount.ToString();
            lblFrist.Visible = currentPageIndex != 1;
            lblLast.Visible = currentPageIndex < PageCount;
            if (RecordCount == 0) return;
            
            int currentpagegroupindex = 1;
            if (currentPageIndex % PageSize == 0) currentpagegroupindex = currentPageIndex / PageSize - 1;
            else currentpagegroupindex = currentPageIndex / pageGroupSize; 
            int currentpageindexstart = currentpagegroupindex * pageGroupSize + 1;
            int currentpageindexend = (currentpagegroupindex + 1) * pageGroupSize;
            if (currentpageindexend > PageCount) currentpageindexend = PageCount;

            if (currentpagegroupindex < PageGroupCount - 1)
            {
                Label label = GenerateLabel("page-next", "...", null, true);
                label.Click += LabelNext_Click;
                pnlPages.Controls.Add(label);
            }

            for (int i = currentpageindexend; i >= currentpageindexstart; i--)
            {
                Label label = GenerateLabel("page-" + i.ToString(), i.ToString(), i.ToString(), i != currentPageIndex);
                label.Click += Label_Click;
                pnlPages.Controls.Add(label);
            }

            if (currentpagegroupindex > 0)
            {
                Label label = GenerateLabel("page-pre", "...", null, true);
                label.Click += LabelPre_Click;
                pnlPages.Controls.Add(label);
            }
        }

        public void DoPaging(int index)
        {
            CurrentPageIndex = index;
            if (Paging != null) Paging.Invoke(this, new PagingEventArgs { CurrentPageIndex = index });
        }

        public void DoPaging()
        {
            DoPaging(currentPageIndex);
        }

        public void InvokePaging(int index)
        {
            DoPaging(index);
            Render();
        }
        #endregion

        #region event
        private void Label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            int index = 1;
            if (label.Tag != null) index = Convert.ToInt32(label.Tag);
            DoPaging(index);
            //Render();
        }

        private void LabelPre_Click(object sender, EventArgs e)
        {
            currentPageIndex = currentPageIndex - pageGroupSize;
            if (currentPageIndex < 1) currentPageIndex = 1;
            DoPaging(currentPageIndex);
            //Render();
        }

        private void LabelNext_Click(object sender, EventArgs e)
        {
            CurrentPageIndex = currentPageIndex + pageGroupSize;
            if (currentPageIndex > PageCount) CurrentPageIndex = PageCount;
            DoPaging(currentPageIndex);
            //Render();
        }

        private void lblFrist_Click(object sender, EventArgs e)
        {
            InvokePaging(1);
        }

        private void lblLast_Click(object sender, EventArgs e)
        {
            InvokePaging(PageCount);
        }

        private void txbGo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPage.Text)) return;
            int index = Convert.ToInt32(txbPage.Text);
            if (index > PageCount) index = PageCount;
            else if (index < 1) index = 1;
            txbPage.Text = index.ToString();
            InvokePaging(index);
        }
        #endregion

        #region private
        private Label GenerateLabel(string name, string text, string tag, bool isLink)
        {
            Label label = new Label();
            label.Name = name;
            label.Tag = tag;
            label.Text = text;
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Left;
            if (isLink)
            {
                label.UseCustomForeColor = true;
                label.ForeColor = Color.Blue;
                label.Cursor = Cursors.Hand;
            }
            return label;
        }
        #endregion
    }

    public delegate void PagingEventHandler(object sender, PagingEventArgs e);

    public class PagingEventArgs : EventArgs
    {
        public int CurrentPageIndex { get; set; }
    }
}
