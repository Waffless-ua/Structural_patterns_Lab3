using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Adapter
{
    public interface ILogger
    {
        public void Log(string message);
        public void Error(string message);
        public void Warn(string message);
    }
}
