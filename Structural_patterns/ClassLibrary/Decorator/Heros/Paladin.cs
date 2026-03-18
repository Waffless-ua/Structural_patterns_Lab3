using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Decorator.Heros
{
    public class Paladin : IHero
    {
        public string Type => "Paladin";
        public int Attack => 15;
        public int Defence => 25;
        public int Speed => 10;
        public void GetStats()
        {
            Console.WriteLine($"Stats of {Type}:");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defence: {Defence}");
            Console.WriteLine($"Speed: {Speed}");
        }
    }
}
