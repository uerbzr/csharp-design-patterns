using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Decorator
{
    public class BasicEngine : IEngine
    {
        public string Description()
        {
            return "Basic Engine";

        }
    }
}
