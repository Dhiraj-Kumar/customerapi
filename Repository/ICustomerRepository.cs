using firstapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstapi.Repository
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        List<Customer> GetCustomers();
        Customer GetCustomer(int id);
        void UpdateCustomer(int id, Customer customer);
        void DeleteCustomer(int id);
    }
}
