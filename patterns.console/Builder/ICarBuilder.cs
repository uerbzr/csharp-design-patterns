using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Builder
{
    public interface ICarBuilder
    {
        ICarBuilder SetMake(string make);
        ICarBuilder SetModel(string model);
        ICarBuilder SetColour(string colour);
        Car Build();
    }

}
