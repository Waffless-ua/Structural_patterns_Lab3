using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Decorator.Heros
{
    public class Mage : IHero
    {
        public string Type => "Mage";
        public int Attack => 25;
        public int Defence => 10;
        public int Speed => 15;
        public void GetStats()
        {
            Console.WriteLine($"Stats of {Type}:");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defence: {Defence}");
            Console.WriteLine($"Speed: {Speed}");
        }
    }
}
