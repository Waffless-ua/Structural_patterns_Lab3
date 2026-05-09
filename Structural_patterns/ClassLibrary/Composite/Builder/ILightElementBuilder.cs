using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite.Builder
{
    public interface ILightElementBuilder
    {
        ILightElementBuilder AddClass(string className);
        ILightElementBuilder AddChild(LightNode node);
        LightElementNode Build();
    }
}
