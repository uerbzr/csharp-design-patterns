using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Observer
{
    public class NiPhoneCustomer : ICustomer
    {
        public void Update(string phone)
        {
            Console.WriteLine($"NiPhone Customer: Excited! A new {phone} is now in stock!");
        }
    }
}
