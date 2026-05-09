using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite.Command
{
    public class AddClassCommand : ICommand
    {
        private LightElementNode element;
        private string className;

        public AddClassCommand(LightElementNode element, string className)
        {
            this.element = element;
            this.className = className;
        }

        public void Execute()
        {
            element.AddClass(className);
        }

        public void Undo()
        {
            element.RemoveClass(className);
        }
    }
}
