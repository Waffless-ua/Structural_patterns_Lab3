using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Adapter
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            WriteConsoleColorText(ConsoleColor.Green, message);
        }
        public void Error(string message)
        {
            WriteConsoleColorText(ConsoleColor.Red, message);
        }
        public void Warn(string message)
        {
            WriteConsoleColorText(ConsoleColor.Yellow, message);
        }
        public void WriteConsoleColorText(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
