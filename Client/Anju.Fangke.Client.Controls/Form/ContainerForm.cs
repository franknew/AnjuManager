using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Reflection;

namespace SOAFramework.Client.Forms
{
    public partial class ContainerForm : MetroForm
    {
        public ContainerForm()
        {
            InitializeComponent();
        }

        public string Token { get; set; }

        public void AddMdiChild(string dllpath, string typename)
        {
            string fullFileName = AppDomain.CurrentDomain.BaseDirectory + "\\" + dllpath;
            FileInfo file = new FileInfo(fullFileName);
            if (!file.Exists)
            {
                throw new Exception("文件：" + fullFileName + "不存在，无法加载该窗体！");
            }
            var assm = Assembly.LoadFile(fullFileName);
            if (assm == null)
            {
                throw new Exception("无法加载文件：" + fullFileName);
            }
            var child = assm.CreateInstance(typename) as ChildForm;
            if (child == null)
            {
                throw new Exception("无法加载窗体：" + typename);
            }
            if (this.MdiChildren.Contains(child))
            {

            }
            else
            {
                child.ControlBox = false;
                child.Resizable = false;
                child.Movable = false;
                child.WindowState = FormWindowState.Maximized;
                child.MdiParent = this;
                child.ShowIcon = false;
                child.ShowInTaskbar = false;
                child.Show();
            }
        }
    }
}
