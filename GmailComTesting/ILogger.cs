using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailRuTesting
{
    internal interface ILogger
    {
        public void LogError(string error);
        public void LogWarning(string warning);
        public void LogInfo(string info);
    }
}
