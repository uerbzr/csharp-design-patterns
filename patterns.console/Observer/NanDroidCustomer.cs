using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Observer
{
    public class NanDroidCustomer : ICustomer
    {
        public void Update(string phone)
        {
            Console.WriteLine($"NanDroid Customer: Awesome! A new {phone} is available!");
        }
    }
}
