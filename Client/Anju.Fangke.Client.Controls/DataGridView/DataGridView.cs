﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework.Controls;
using System.ComponentModel;
using SOAFramework.Library;
using System.Windows.Forms;
using MetroFramework.Drawing;
using System.Data;
using System.Collections;

namespace SOAFramework.Client.Controls
{
    public class DataGridView : System.Windows.Forms.DataGridView, IServiceBindable
    {
        #region attribute

        #endregion

        #region property

        #endregion

        #region service binding property
        private string controlBindingPropertyName = "DataSource";

        [Category(ControlCategory.Category)]
        [DefaultValue("DataSource")]
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
        public string BindingRequestPropertyName { get; set; }

        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string BindingResponsePropertyName { get; set; }

        public object CollectBindingData()
        {
            return this.GetValue(controlBindingPropertyName);
        }
        #endregion

        protected override void OnLayout(LayoutEventArgs e)
        {
            this.AutoGenerateColumns = false;
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.BackgroundColor = MetroPaint.BackColor.Form(MetroFramework.MetroThemeStyle.Default);
            base.OnLayout(e);
        }

        #region action
        public DataGridViewRow NewRow()
        {
            DataGridViewRow dgvrow = null;
            int firstDisplayColumnIndex = 0;
            object source = this.DataSource;
            if (this.DataSource is BindingSource)
            {
                var binding = (this.DataSource as BindingSource);
                source = binding.DataSource;
            }
            if (source == null)
            {
                DataTable table = new DataTable();
                foreach (DataGridViewColumn c in this.Columns)
                {
                    DataColumn column = new DataColumn(c.DataPropertyName, GetColumnValueType(c));
                    table.Columns.Add(column);
                }
                source = table;
            }
            Type sourcetype = source.GetType();
            object boundvalue = null;
            if (source is DataTable)
            {
                DataTable table = this.DataSource as DataTable;
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                boundvalue = row;
            }
            else if (source is IList && sourcetype.IsGenericType)
            {
                IList list = this.DataSource as IList;
                var valuetype = sourcetype.GetGenericArguments()[0];
                var value = Activator.CreateInstance(valuetype);
                list.Add(value);
                boundvalue = value;
            }
            else if (sourcetype.IsArray)
            {
                IList list = this.DataSource as IList;
                var valuetype = sourcetype.GetElementType();
                var value = Activator.CreateInstance(valuetype);
                list.Add(value);
                boundvalue = value;
            }

            foreach (DataGridViewRow tmp in this.Rows)
            {
                if (tmp.DataBoundItem.Equals(boundvalue))
                {
                    dgvrow = tmp;
                    break;
                }
            }
            foreach (DataGridViewColumn column in this.Columns)
            {
                if (column.Displayed)
                {
                    firstDisplayColumnIndex = column.Index;
                    break;
                }
            }
            this.CurrentCell = dgvrow.Cells[firstDisplayColumnIndex];
            this.FirstDisplayedScrollingRowIndex = dgvrow.Index;
            return dgvrow;
        }
        #endregion

        #region helper
        private Type GetColumnValueType(DataGridViewColumn c)
        {
            Type type = typeof(string);
            if (c is DataGridViewTextBoxColumn)
            {
                type = typeof(string);
            }
            else if (c is DataGridViewCheckBoxColumn)
            {
                type = typeof(int);
            }
            else if (c is DataGridViewComboBoxColumn)
            {
                type = typeof(object);
            }
            return type;
        }
        #endregion
    }
}
