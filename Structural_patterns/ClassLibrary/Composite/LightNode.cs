using ClassLibrary.Composite.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite
{
    public abstract class LightNode
    {
        public virtual string OuterHTML()
        {
            return RenderOpening() + RenderContent() + RenderClosing();
        }

        protected virtual string RenderOpening() => "";
        protected virtual string RenderContent() => InnerHTML();
        protected virtual string RenderClosing() => "";

        public abstract string InnerHTML();
        public abstract void Accept(IVisitor visitor);
    }
}
