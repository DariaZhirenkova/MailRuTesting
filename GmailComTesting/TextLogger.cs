using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailRuTesting
{
    internal class TextLogger : ILogger
    {
        private string _fileName;
        public TextLogger(string fileName)
        {
            _fileName = fileName;
        }
        public void LogError(string error)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(string info)
        {
            using (StreamWriter writer = new StreamWriter(_fileName, true))
            {
                writer.WriteLine(info);
            }
        }

        public void LogWarning(string warning)
        {
            throw new NotImplementedException();
        }
    }
}
