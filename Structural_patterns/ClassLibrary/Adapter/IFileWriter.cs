using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Adapter
{
    public interface IFileWriter
    {
        public void Write(string message);
        public void WriteLine(string message);
    }
}
