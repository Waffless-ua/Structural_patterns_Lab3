using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Decorator
{
    public interface IHero
    {
        string Type { get; }
        int Attack { get; }
        int Defence { get; }
        int Speed { get; }
        public void GetStats();
    }
}
