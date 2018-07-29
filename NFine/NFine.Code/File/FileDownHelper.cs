/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using System;
using System.IO;
using System.Threading;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NFine.Code
{
    public class FileDownHelper
    {

        private IHostingEnvironment _hostingEnvironment;

        public FileDownHelper(IHostingEnvironment hostingEnvironent)
        {
            _hostingEnvironment = hostingEnvironent;
        }

        public string FileNameExtension(string FileName)
        {
            return Path.GetExtension(MapPathFile(FileName));
        }
        public string MapPathFile(string FileName)
        {
            return _hostingEnvironment.ContentRootPath + (FileName);
        }
        public bool FileExists(string FileName)
        {
            string destFileName = FileName;
            if (File.Exists(destFileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
