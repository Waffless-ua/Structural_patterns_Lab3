using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite.Visitor
{
    public class HtmlStatisticsVisitor : IVisitor
    {
        public int ElementCount { get; private set; }
        public int TextNodeCount { get; private set; }
        public int ImagesCount { get; private set; }

        public void Visit(LightTextNode textNode)
        {
            TextNodeCount++;
        }

        public void Visit(LightElementNode elementNode)
        {
            ElementCount++;
        }

        public void Visit(LightImageNode imageNode)
        {
            ImagesCount++;
        }
    }
}
