using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logger.ClsLogger;

namespace Logger
{
    public class ClsLogger(LogAction logAction)
    {
        public delegate void LogAction(string message);

        LogAction _logAction = logAction;

        public void Log(string message)
        {
            _logAction(message);
        }
    }
}
