using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite.Strategy
{
    public class NetworkImageLoadStrategy : IImageLoadStrategy
    {
        public string Load(string href)
        {
            return $"[Image loaded from URL: {href}]";
        }
    }
}
