/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using log4net;
using System;
using System.IO;
using System.Web;
using log4net.Repository;
using Microsoft.AspNetCore.Http;

namespace NFine.Code
{
    public class LogFactory
    {
        static LogFactory()
        {
            ILoggerRepository repository = LogManager.CreateRepository("NETCoreRepository");
            FileInfo configFile = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + ("/Configs/log4net.config"));
            log4net.Config.XmlConfigurator.Configure(repository, configFile);
        }
        public static Log GetLogger(Type type)
        {
            return new Log(LogManager.GetLogger(type));
        }
        //public static Log GetLogger(string str)
        //{
        //    return new Log(LogManager.GetLogger(str));
        //}
    }
}
