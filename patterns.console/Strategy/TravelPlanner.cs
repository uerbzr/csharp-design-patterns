using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.StrategyPattern
{
    public class TravelPlanner
    {
        private TravelStrategy _travelStrategy;

        public void SetTravelStrategy(TravelStrategy travelStrategy)
        {
            _travelStrategy = travelStrategy;
        }

        public void Drive(int kilometers)
        {
            var cost = _travelStrategy.Drive(kilometers);
            Console.WriteLine($"Cost of the drive: {cost} in a {travelStrategy.GetType().Name}");
        }

        public TravelStrategy travelStrategy => _travelStrategy;
    }
}
