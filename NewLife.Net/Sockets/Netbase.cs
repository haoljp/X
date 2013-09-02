﻿using System;
using System.Diagnostics;
using System.Reflection;
using NewLife.Log;
using NewLife.Reflection;

namespace NewLife.Net.Sockets
{
    /// <summary>网络基类，提供资源释放和日志输出的统一处理</summary>
    public abstract class Netbase : DisposeBase
    {
        #region 构造销毁
        static Netbase()
        {
            var asmx = AssemblyX.Create(Assembly.GetExecutingAssembly());
            XTrace.WriteLine("{0} v{1} Build {2:yyyy-MM-dd HH:mm:ss}", asmx.Name, asmx.FileVersion, asmx.Compile);
        }
        #endregion

        #region 日志
        private Boolean? _EnableLog;
        /// <summary>是否显示日志。默认是NetHelper.Debug</summary>
        public virtual Boolean EnableLog { get { return _EnableLog ?? NetHelper.Debug; } set { _EnableLog = value; } }

        /// <summary>写日志</summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public void WriteLog(String format, params Object[] args)
        {
            if (EnableLog) NetHelper.WriteLog(format, args);
        }

        /// <summary>写调试日志</summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        [Conditional("DEBUG")]
        public void WriteDebugLog(String format, params Object[] args)
        {
            if (EnableLog) NetHelper.WriteLog(format, args);
        }
        #endregion
    }
}