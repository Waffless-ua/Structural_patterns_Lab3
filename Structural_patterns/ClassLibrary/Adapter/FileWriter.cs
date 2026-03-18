using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Adapter
{
    public class FileWriter : IFileWriter
    {
        private readonly string _filePath;
        public FileWriter(string filePath)
        {
            _filePath = filePath;
        }
        public void Write(string message)
        {
            File.AppendAllText(_filePath, message);
        }
        public void WriteLine(string message)
        {
            var line = message + Environment.NewLine;
            File.AppendAllText(_filePath, line);
        }
    }
}
