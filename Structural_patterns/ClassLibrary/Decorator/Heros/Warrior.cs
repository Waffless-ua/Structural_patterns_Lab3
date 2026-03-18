using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Decorator.Heros
{
    public class Warrior : IHero
    {
        public string Type => "Warrior";
        public int Attack => 20;
        public int Defence => 20;
        public int Speed => 20;
        public void GetStats()
        {
            Console.WriteLine($"Stats of {Type}:");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defence: {Defence}");
            Console.WriteLine($"Speed: {Speed}");
        }
    }
}