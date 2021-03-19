using LIMS.Common.LOG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight
{
    class LogHelper
    {
        public static SystemLog _log = new SystemLog("物重取值");

        public static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now.ToString()}----{msg}");
            _log.WriteLog( E_ProcessLogType.Info, $"{msg}");
        }


    }
}
