using System;
using System.Diagnostics;

namespace Magenic.Cli
{
    public class CliService
    {
        public string GetServiceName()
        {
            var st = new StackTrace();
            return st.GetFrame(1).GetMethod().Name;
        }
    }
}