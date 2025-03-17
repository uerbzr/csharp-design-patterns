using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Decorator
{
    public abstract class EngineDecorator : IEngine
    {
        protected IEngine _engine;
        public EngineDecorator(IEngine engine)
        {
            _engine = engine;
        }
        public virtual string Description()
        {
            return _engine.Description();
        }

    }
}
