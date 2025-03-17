using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.console.Observer
{
    public class PhoneStore
    {
        private List<ICustomer> customers = new List<ICustomer>();
        private string latestPhone = string.Empty;

        public void AddCustomer(ICustomer customer)
        {
            customers.Add(customer);
        }

        public void RemoveCustomer(ICustomer customer)
        {
            customers.Remove(customer);
        }

        public void NewPhoneArrival(string phone)
        {
            latestPhone = phone;
            NotifyCustomers();
        }

        private void NotifyCustomers()
        {
            foreach (var customer in customers)
            {
                customer.Update(latestPhone);
            }
        }
    }

}
