using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Api
{
    public class VersionApi
    {
        private VersionBLL bll = new VersionBLL();

        /// <summary>
        /// 获得程序必须的文件
        /// </summary>
        /// <returns></returns>
        public List<FileVersion> GetNecessaryFiles()
        {
            return bll.GetNecessaryFiles();
        }

        /// <summary>
        /// 下载必须的文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string DownloadNecessaryFile(string fileName)
        {
            return bll.DownloadNecessaryFile(fileName);
        }
    }
}
