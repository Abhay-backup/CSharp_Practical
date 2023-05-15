    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.DIP
{
    public interface ICustomerRepositoryAfterDIP
    {
        void Add(Customer customer);
    }


    // CustomerRepositoryAfterDIP class Lower-level module
    public class CustomerRepositoryAfterDIP : ICustomerRepositoryAfterDIP
    {
        public void Add(Customer customer)
        {
            // Add the customer to the database
        }
    }

    public class CustomerServiceAfterDIP
    {
        private readonly ICustomerRepositoryAfterDIP repositoryAfterDIP;

        public CustomerServiceAfterDIP(ICustomerRepositoryAfterDIP repositoryAfterDIP)
        {
            this.repositoryAfterDIP = repositoryAfterDIP;
        }

        public void AddCustomer(Customer customer)
        {
            // Some logic for adding a customer
            repositoryAfterDIP.Add(customer);
        }
    }


}
