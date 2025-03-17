using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Command
{
    public class Calculator
    {
        private int _currentValue = 0;

        public void Operation(char operatorType, int operand)
        {
            switch (operatorType)
            {
                case '+': _currentValue += operand; break;
                case '-': _currentValue -= operand; break;
            }
            Console.WriteLine($"Current Value: {_currentValue}");
        }
    }

}
