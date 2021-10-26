using firstapi.Models;
using firstapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository repo;

        public CustomerController(ICustomerRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repo.GetCustomers());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(repo.GetCustomer(id));
        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            repo.AddCustomer(customer);
            return Ok("Customer Information added successfully");
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Customer customer)
        {
            repo.UpdateCustomer(id, customer);
            return Ok("Customer Information Updated successfully");
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            repo.DeleteCustomer(id);
            return Ok("Customer Information deleted successfully");
        }
    }
}
