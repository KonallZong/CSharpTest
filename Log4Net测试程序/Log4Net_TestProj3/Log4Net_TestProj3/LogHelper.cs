﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace Log
{
   public class LogHelper
    {

        System.IO.FileInfo fi = new System.IO.FileInfo("Log4Net.config");
        ILog logger_Fatal;
        ILog logger_Error;
        ILog logger_Waring;
        ILog logger_Debug;      
        ILog logger_Info;
        public LogHelper()
        {
            log4net.Config.XmlConfigurator.Configure(fi);
            logger_Fatal = log4net.LogManager.GetLogger("Logger_Fatal");
            logger_Error = log4net.LogManager.GetLogger("Logger_Error");
            logger_Waring = log4net.LogManager.GetLogger("Logger_Warn");
            logger_Debug = log4net.LogManager.GetLogger("Logger_Debug");
            logger_Info = log4net.LogManager.GetLogger("Logger_Info");
        }

        public void WriteLog(LogLevel level,string info)
        {
            switch (level)
            {
                case LogLevel.Fatal:
                    Fatal(info);
                    break;
                case LogLevel.Error:
                    Error(info);
                    break;
                case LogLevel.Warning:
                    Warning(info);
                    break;
                case LogLevel.Debug:
                    Debug(info);
                    break;
                case LogLevel.Info:
                    Info(info);
                    break;
                default:
                    break;
            }
        }

        public void WriteLog(LogLevel level, string info, Exception ex)
        {
            switch (level)
            {
                case LogLevel.Fatal:
                    Fatal(info,ex); 
                    break;
                case LogLevel.Error:
                    Error(info,ex);
                    break;
                case LogLevel.Warning:
                    Warning(info,ex);
                    break;
                case LogLevel.Debug:
                    Debug(info,ex);
                    break;
                case LogLevel.Info:
                    Info(info,ex);
                    break;
                default:
                    break;
            }
        }

        #region Fatal

        private void Fatal(string info)
        {
            logger_Fatal.Fatal(info);
        }

        private void Fatal(string info, Exception ex)
        {
            logger_Fatal.Fatal(info, ex);
        }

        #endregion

        #region Error

        private void Error(string info)
        {
            logger_Error.Error(info);
        }

        private void Error(string info,Exception ex)
        {
            logger_Error.Error(info,ex);
        }

        #endregion

        #region Warning

        private void Warning(string info)
        {
            logger_Waring.Warn(info);
        }

        private void Warning(string info,Exception ex)
        {
            logger_Waring.Warn(info,ex);
        }

        #endregion

        #region Debug

        private void Debug(string info)
        {
            logger_Debug.Debug(info);
        }


        private void Debug(string info,Exception ex)
        {
            logger_Debug.Debug(info,ex);
        }

        #endregion

        #region Info

        private void Info(string info)
        {
            logger_Info.Info(info);
        }

        private void Info(string info,Exception ex)
        {
            logger_Info.Info(info,ex);
        }
        #endregion


    }

    public enum LogLevel
    {
        Fatal=1,
        Error=2,
        Warning=3,
        Debug=5,
        Info=6
    }
}
