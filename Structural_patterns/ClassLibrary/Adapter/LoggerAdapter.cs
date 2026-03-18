using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Adapter
{
    public class LoggerAdapter :  ILogger
    {
        private IFileWriter _writer;
        public LoggerAdapter(IFileWriter writer)
        {
            _writer = writer;
        }
        public void Log(string message)
        {
            _writer.WriteLine("[Log] " + message);
        }
        public void Error(string message)
        {
            _writer.WriteLine("[Error] " + message);
        }
        public void Warn(string message)
        {
            _writer.WriteLine("[Warn] " + message);
        }
    }
}
