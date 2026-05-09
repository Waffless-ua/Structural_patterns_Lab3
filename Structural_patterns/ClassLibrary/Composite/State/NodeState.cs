using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite.State
{
    public abstract class NodeState
    {
        protected LightNode context;
        internal void SetContext(LightNode node)
        {
            context = node;
        }

        public abstract string Render();
    }
}
