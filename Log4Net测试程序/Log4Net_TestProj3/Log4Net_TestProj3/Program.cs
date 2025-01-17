﻿using Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log4Net_TestProj3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LogHelper logHelper = new LogHelper();

                logHelper.WriteLog(LogLevel.Fatal,"FatalMsg");
                logHelper.WriteLog(LogLevel.Fatal, "FatalMsg",new Exception("FatalEx"));

                logHelper.WriteLog(LogLevel.Error, "ErrorMsg");
                logHelper.WriteLog(LogLevel.Error, "ErrorMsg", new Exception("ErrorEx"));


                logHelper.WriteLog(LogLevel.Warning, "WarningMsg");
                logHelper.WriteLog(LogLevel.Warning, "WarningMsg", new Exception("WarningEx"));

                logHelper.WriteLog(LogLevel.Debug, "DebugMsg");
                logHelper.WriteLog(LogLevel.Debug, "DebugMsg", new Exception("DebugEx"));

                logHelper.WriteLog(LogLevel.Info, "InfoMsg");
                logHelper.WriteLog(LogLevel.Info, "InfoMsg", new Exception("InfoEx"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Test Success");
            Console.ReadLine();
        }
    }
}
