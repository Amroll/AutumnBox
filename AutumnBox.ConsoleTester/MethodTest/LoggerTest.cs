﻿/* =============================================================================*\
*
* Filename: LoggerTest
* Description: 
*
* Version: 1.0
* Created: 2017/10/31 3:22:34 (UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/
using AutumnBox.Shared.CstmDebug;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutumnBox.ConsoleTester.MethodTest
{
    //[LogProperty(TAG = "Testing...", Show = true)]
    public class LoggerTest
    {
        //[LogProperty(TAG = "Test Method",Show =false)]
        public static void Test()
        {
            Logger.D("Wow!");
        }
        [LogProperty(Show = true)]
        public static void ExpTest()
        {
            Logger.D("Wtf!", true);
            Logger.D("hehe", new FileNotFoundException("GG"));
        }
        [LogProperty(TAG = "Speed Test")]
        public static void SpeedTest(int maxValue = 1000)
        {
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < maxValue; i++)
            {
                Logger.D(i.ToString());
            }
            DateTime finishTime = DateTime.Now;
            TimeSpan useTime = finishTime - startTime;
            Console.WriteLine("use " + useTime.TotalMilliseconds + $"ms by {maxValue} log print");
            Console.WriteLine("average " + Math.Round((useTime.TotalMilliseconds / maxValue), 3).ToString() + " ms");
        }
    }
}
