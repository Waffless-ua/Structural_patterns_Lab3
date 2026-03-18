using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Decorator.Heros
{
    public class Artifact : InventoryDecorator
    {
        public Artifact(IHero hero) : base(hero) { }
        public override int Attack => base.Attack + 5;
        public override int Defence => base.Defence - 5;
        public override int Speed => base.Speed;

    }
}
