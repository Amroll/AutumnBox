﻿using AutumnBox.GUI.Models;
using AutumnBox.GUI.MVVM;
using System.Collections.Generic;

namespace AutumnBox.GUI.ViewModels
{
    class VMUpdateLogs : ViewModelBase
    {
        public IEnumerable<VersionInfo> Versions
        {
            get => _vers; set
            {
                _vers = value;
                RaisePropertyChanged();
            }
        }
        private IEnumerable<VersionInfo> _vers;

        public VMUpdateLogs()
        {
            Versions = data;
        }

        private static readonly IEnumerable<VersionInfo> data = new List<VersionInfo>()
        {
          new VersionInfo("2019.6.8-preview","2019-6-8","界面进一步整合,新的主页内容机制,BUG修复,加入SharpZipLib的引用"),
         new VersionInfo("2019.5.30-preview","2019-5-30","界面革新,大量模块重构"),
         new VersionInfo("2019.4.13","2019-4-13","一些信息修改"),
              new VersionInfo("2019.3.11","2019-3-11","细节BUG修复,支持一键激活太极"),
            new VersionInfo("2019.3.5","2019-3-5","秋之盒三月更新来袭,诸多新特性,全新API,界面设计优化"),
            new VersionInfo("2019.1.18","2019-1-18","紧急修复一个臭名昭著的恶性BUG"),
            new VersionInfo("2019.1.11","2019-1-11","强烈建议更新,这个版本将是将来所有拓展模块的基础版本\n优化绿守激活器\n修复大量BUG"),
            new VersionInfo("2019.1.2","2019-1-2","修复了正式版中的网络调试BUG,这是个紧急版本"),

    };
    }
}
