using ClassLibrary.Composite.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite.Builder
{
    public class LightElementBuilder : ILightElementBuilder
    {
        private readonly LightElementNode element;

        public LightElementBuilder(string tagName, bool isSelfClosing = false)
        {
            element = new LightElementNode(tagName, isSelfClosing, new VisibleState());
        }

        public ILightElementBuilder AddClass(string className)
        {
            element.AddClass(className);
            return this;
        }

        public ILightElementBuilder AddChild(LightNode node)
        {
            element.AddChild(node);
            return this;
        }

        public LightElementNode Build()
        {
            return element;
        }
    }
}
