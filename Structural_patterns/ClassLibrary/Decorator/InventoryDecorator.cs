using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Decorator
{
    public abstract class InventoryDecorator : IHero
    {
        protected IHero _hero;
        public InventoryDecorator(IHero hero) : base() 
        {
            _hero = hero;
        }
        public string Type => _hero.Type;
        public virtual int Attack => _hero.Attack;
        public virtual int Defence => _hero.Defence;
        public virtual int Speed => _hero.Speed;

        public void GetStats()
        {
            Console.WriteLine($"Stats of {Type}:");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defence: {Defence}");
            Console.WriteLine($"Speed: {Speed}");
        }
    }
}
