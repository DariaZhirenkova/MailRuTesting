using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailRuTesting
{
    internal class LoggerManager
    {
        public static ILogger GetLoggerInstance()
        {
            return new TextLogger("C:\\Users\\Zhire\\source\\repos\\MailRuTesting\\loggerMail.txt");
        }
    }
}
