using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite.Strategy
{
    public class FileImageLoadStrategy : IImageLoadStrategy
    {
        public string Load(string href)
        {
            if (File.Exists(href))
            {
                return $"[Image loaded from file: {href}]";
            }
            return "[File not found]";
        }
    }
}



