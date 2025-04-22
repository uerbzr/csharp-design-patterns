using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Builder
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Colour: {Colour}";
        }
    }
}
