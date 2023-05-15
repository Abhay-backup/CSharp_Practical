using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.DIP
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class CustomerRepositorybrforeDIP
    {
        public void Add(Customer customer)
        {
            // Add the customer to the database
        }
    }

    public class CustomerServicebrforeDIP
    {
        private readonly CustomerRepositorybrforeDIP repositorybrforeDIP;

        public CustomerServicebrforeDIP()
        {
            this.repositorybrforeDIP = new CustomerRepositorybrforeDIP();
        }

        public void AddCustomer(Customer customer)
        {
            // Some logic for adding a customer repository.Add(customer);
        }
    }
}
