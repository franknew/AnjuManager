using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using SOAFramework.Library;
using System.Diagnostics;
using IWshRuntimeLibrary;

namespace Anju.Fangke.Client.Launcher
{
    public partial class Laucher : Form
    {
        public Laucher()
        {
            InitializeComponent();
            _worker.DoWork += Worker_DoWork;
            _worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            _worker.WorkerReportsProgress = true;
        }

        private BackgroundWorker _worker = new BackgroundWorker();
        private List<FileVersion> files = new List<FileVersion>();
        private string _managerPath = "";
        private string _entry = "Anju.Fangke.Client.Main.exe";
        private int _value = 0;

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                string fullentry = _managerPath.TrimEnd('\\') + "\\" + _entry;
                FileInfo file = new FileInfo(fullentry);
                //创建快捷方式
                string desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                WshShell shell = new WshShellClass();
                IWshShortcut shortcut = shell.CreateShortcut(desktoppath + "\\房客易租.lnk") as IWshShortcut;
                shortcut.TargetPath = fullentry;
                shortcut.Description = "房客易租管理系统";
                shortcut.WorkingDirectory = file.Directory.FullName;
                //shortcut.IconLocation = "";
                shortcut.WindowStyle = 1;
                shortcut.Save();
                Process.Start(fullentry);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                _value = 0;
                foreach (var file in files)
                {
                    _value++;
                    string fullfilename = _managerPath.TrimEnd('\\') + "\\" + file.FileName.TrimStart('\\');
                    FileInfo saveFile = new FileInfo(fullfilename);
                    if (!saveFile.Directory.Exists)
                    {
                        saveFile.Directory.Create();
                    }
                    DownloadFileRequest request = new DownloadFileRequest();
                    request.FileName = file.FileName;
                    var response = SDKFactory.Client.Execute(request);
                    response.FileContent.ToFile(fullfilename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progress.Value = _value;
        }

        private void Laucher_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["AnjuManagerPath"]))
            {
                _managerPath = ConfigurationManager.AppSettings["AnjuManagerPath"].Replace("{AppDir}", AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\'));
            }
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Entry"]))
            {
                _entry = ConfigurationManager.AppSettings["Entry"].Replace("{AppDir}", AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\'));
            }
            GetNecessaryFilesRequest request = new GetNecessaryFilesRequest();
            var response = SDKFactory.Client.Execute(request);
            foreach (var file in response.Files)
            {
                string fullfilename = _managerPath.TrimEnd('\\') + "\\" + file.FileName.TrimStart('\\');
                FileInfo saveFile = new FileInfo(fullfilename);
                if (!saveFile.Exists || saveFile.LastWriteTime < file.LastModifyTime)
                {
                    files.Add(file);
                }
            }
            progress.Maximum = files.Count;
            timer.Start();
            this.Text = "正在下载必要的系统文件...";
            _worker.RunWorkerAsync();
        }
    }
}
