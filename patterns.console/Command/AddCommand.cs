using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Command
{
    public class AddCommand : ICommand
    {
        private readonly Calculator _calculator;
        private readonly int _operand;

        public AddCommand(Calculator calculator, int operand)
        {
            _calculator = calculator;
            _operand = operand;
        }

        public void Execute() => _calculator.Operation('+', _operand);
        public void Undo() => _calculator.Operation('-', _operand);
    }
}
