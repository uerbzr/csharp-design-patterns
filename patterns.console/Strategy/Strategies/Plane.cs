using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using patterns.console.StrategyPattern;

namespace patterns.console.Strategy.Strategies
{
    public class Plane : TravelStrategy
    {
        public Plane()
        {
            KilometerCost = 150;
        }

        public override decimal Drive(int kilometers)
        {
            if (kilometers > 1000)
            {
                KilometerCost = 15;
            }

            return kilometers * KilometerCost;
        }
    }
}
