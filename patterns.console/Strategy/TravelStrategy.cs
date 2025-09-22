using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.StrategyPattern
{
    public abstract class TravelStrategy
    {
        public int CostPerKilometer { get; set; }
        public abstract decimal Drive(int kilometers);
    }
}
