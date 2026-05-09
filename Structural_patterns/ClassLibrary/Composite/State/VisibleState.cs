using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite.State
{
    public class VisibleState : NodeState
    {
        public override string Render()
        {
            return context.OuterHTML();
        }
    }
}
