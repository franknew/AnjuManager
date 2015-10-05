using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SOAFramework.Library;
using Anju.Fangke.Server.Model;

namespace Anju.Fangke.Server.BLL
{
    public class VersionBLL
    {
        public List<FileVersion> GetNecessaryFiles()
        {
            List<FileVersion> list = new List<FileVersion>();
            DirectoryInfo directory = new DirectoryInfo(Common.NecessaryFilePath);
            if (!directory.Exists)
            {
                return list;
            }
            var files = directory.GetFiles("*.*");
            foreach (var file in files)
            {
                list.Add(new FileVersion
                {
                    FullFileName = file.FullName.Replace(Common.NecessaryFilePath, ""),
                    LastModifyTime = file.LastWriteTime,
                    FileName = file.Name,
                });
            }
            return list;
        }
        
        public string DownloadNecessaryFile(string fileName)
        {
            string fullfilename = Common.NecessaryFilePath.Trim('\\') + "\\" + fileName.TrimStart('\\');
            FileInfo file = new FileInfo(fullfilename);
            if (!file.Exists)
            {
                throw new Exception("文件：" + fileName + "不存在！");
            }
            return file.FileToString();
        }
    }
}
