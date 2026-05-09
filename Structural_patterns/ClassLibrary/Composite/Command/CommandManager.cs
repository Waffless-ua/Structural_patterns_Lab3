using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite.Command
{
    public class CommandManager
    {
        private Stack<ICommand> history = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            history.Push(command);
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                var command = history.Pop();
                command.Undo();
            }
        }
    }
}
