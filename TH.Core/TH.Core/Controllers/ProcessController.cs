using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.Core.Controllers
{
    public static class ProcessController
    {
        public static void RunExeFile(string path)
        {
            Process process = new Process();
            process.StartInfo.FileName = path;
            process.Start();
        }
    }
}
