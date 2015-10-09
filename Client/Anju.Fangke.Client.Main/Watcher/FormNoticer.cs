using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anju.Fangke.Client.Main
{
    public class FormNoticer : IControlNoticer
    {
        public ControlWatcher Watcher { get; set; }

        protected List<Form> listForm = new List<Form>();

        private Form containerForm = null;

        private string controlName = "";

        public FormNoticer(string controlName, Form mainForm)
        {
            this.controlName = controlName;
            this.containerForm = mainForm;
        }

        public virtual void Add(string name, string text)
        {
            Form form = containerForm.MdiChildren.First(t => t.Name.Equals(name));
            listForm.Add(form);
            Activate(name);
        }

        public virtual void Remove(string name)
        {
            Form form = listForm.Find(t => t.Name == name);
            if (form == null)
            {
                return;
            }
            form.Close();
            listForm.Remove(form);
        }

        public virtual void Clear()
        {
            foreach (var form in listForm)
            {
                Remove(form.Name);
            }
        }

        public virtual void Activate(string name)
        {
            listForm.ForEach(t =>
            {
                t.AutoValidate = AutoValidate.Disable;
            });
            Form form = listForm.Find(t => t.Name == name);
            if (form == null)
            {
                return;
            }
            form.Activate();
            form.AutoValidate = AutoValidate.EnablePreventFocusChange;
            if (form.ActiveControl != null)
            {
                form.ActiveControl.Focus();
            }
        }

        private void ActivateForm(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            Form form = containerForm.MdiChildren.First(t => t.Name == item.Name);
            if (form == null)
            {
                return;
            }
            Activate(item.Name);
        }
    }
}
