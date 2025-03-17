using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Command
{
    public class CalculatorInvoker
    {
        private readonly Stack<ICommand> _history = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_history.Count > 0)
            {
                ICommand lastCommand = _history.Pop();
                lastCommand.Undo();
            }
        }
    }
}
