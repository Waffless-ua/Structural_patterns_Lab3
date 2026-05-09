using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite.Visitor
{
    public interface IVisitor
    {
        void Visit(LightTextNode textNode);

        void Visit(LightElementNode elementNode);
        void Visit(LightImageNode imageNode);
    }
}
