using patterns.console.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Strategy.Strategies
{
    public class Bus : TravelStrategy
    {
        public Bus()
        {
            CostPerKilometer = 1;
        }
        public override decimal Drive(int kilometers)
        {
            return kilometers * CostPerKilometer;
        }
    }
}
