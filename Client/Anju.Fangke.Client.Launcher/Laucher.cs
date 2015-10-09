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
using System.Reflection;

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
        private string _versionfile = "version.json";
        private string _versionpath = "";

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                string fullentry = _managerPath.TrimEnd('\\') + "\\" + _entry;
                string iconpath = _managerPath.TrimEnd('\\') + "\\" + "房客易租.ico";
                FileInfo file = new FileInfo(fullentry);
                FileInfo icon = new FileInfo(iconpath);

                //创建快捷方式
                string desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                WshShell shell = new WshShellClass();
                IWshShortcut shortcut = shell.CreateShortcut(desktoppath + "\\房客易租.lnk") as IWshShortcut;
                shortcut.TargetPath = Assembly.GetEntryAssembly().Location;
                shortcut.Description = "房客易租管理系统";
                shortcut.WorkingDirectory = file.Directory.FullName;
                if (icon.Exists)
                {
                    shortcut.IconLocation = icon.FullName;
                }
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
                    if (!file.NeedUpdate)
                    {
                        continue;
                    }
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
                    file.NeedUpdate = false;
                    //保存版本信息
                    string versionjson = JsonHelper.Serialize(files);
                    System.IO.File.WriteAllText(_versionpath, versionjson, Encoding.UTF8);
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
            //检查系统是否已经运行
            FileInfo entryfile = new FileInfo(_entry);
            while (1 == 1)
            {
                var process = Process.GetProcessesByName(entryfile.Name.Remove(entryfile.Name.LastIndexOf("."), 4));
                if (process != null && process.Length > 0)
                {
                    switch (MessageBox.Show(this, "检测到被房客易租管理系统正在运行，请先关闭客易租管理系统，然后点击重试！", "警告", MessageBoxButtons.RetryCancel))
                    {
                        case DialogResult.Cancel:
                            Application.Exit();
                            return;
                        case DialogResult.Retry:
                            break;
                    }
                }
                else
                {
                    break;
                }
            }

            //读取版本信息
            _versionpath = _managerPath.TrimEnd('\\') + "\\" + _versionfile;
            List<FileVersion> versionFiles = new List<FileVersion>();
            if (System.IO.File.Exists(_versionpath))
            {
                string versionjson = System.IO.File.ReadAllText(_versionpath);
                versionFiles = JsonHelper.Deserialize<List<FileVersion>>(versionjson);
            }
            GetNecessaryFilesRequest request = new GetNecessaryFilesRequest();
            var response = SDKFactory.Client.Execute(request);
            foreach (var file in response.Files)
            {
                string fullfilename = _managerPath.TrimEnd('\\') + "\\" + file.FileName.TrimStart('\\');
                FileInfo saveFile = new FileInfo(fullfilename);

                var version = versionFiles.Find(t => t.FileName == file.FileName);
                if (version == null || version.LastModifyTime < file.LastModifyTime || !saveFile.Exists)
                {
                    file.NeedUpdate = true;
                }
                files.Add(file);
            }
            progress.Maximum = files.Count(t => t.NeedUpdate);
            timer.Start();
            this.Text = "正在下载必要的系统文件...";
            _worker.RunWorkerAsync();
        }
    }
}
