using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Builder
{
    public class CarBuilder : ICarBuilder
    {
        private Car _car = new();

        public ICarBuilder SetMake(string make)
        {
            _car.Make = make;
            return this;
        }

        public ICarBuilder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public ICarBuilder SetColour(string colour)
        {
            _car.Colour = colour;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }

}
