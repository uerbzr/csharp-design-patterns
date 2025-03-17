using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Decorator
{
    public class SuperEngine : EngineDecorator
    {
        public SuperEngine(IEngine engine) : base(engine)
        {
        }
        public override string Description()
        {
            return base.Description() + " + Super Engine";
        }
    }        
}
