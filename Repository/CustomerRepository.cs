using firstapi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace firstapi.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        static List<Customer> customerlist = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customerlist.Add(customer);
        }

        public void DeleteCustomer(int id)
        {
            var cust = customerlist.Where(x => x.Id == id).FirstOrDefault();
            if (cust != null)
            {
                customerlist.Remove(cust);
            }
        }

        public Customer GetCustomer(int id)
        {
            return customerlist.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Customer> GetCustomers()
        {
            return customerlist.ToList();
        }

        public void UpdateCustomer(int id, Customer customer)
        {
            var cust = customerlist.Where(x => x.Id == id).FirstOrDefault();
            if (cust != null)
            {
                cust.Name = customer.Name;
                cust.Email = customer.Email;
                cust.City = customer.City;
                cust.Age = customer.Age;
            }
        }
    }
}
