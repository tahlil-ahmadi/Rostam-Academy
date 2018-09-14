using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Interface.RestApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Interface.RestApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private static List<Customer> _customers = new List<Customer>()
        {
            new Customer(){Id = 1, Firstname = "Tom", Lastname = "Hanks"},
            new Customer(){Id = 2, Firstname = "David", Lastname = "Hasselhof"},
        };

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customers;
        }

        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customers.First(a => a.Id == id);
        }

        [HttpPost]
        public void Post([FromBody]Customer value)
        {
            value.Id = _customers.Max(a => a.Id) + 1;
            _customers.Add(value);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Customer value)
        {
            var targetCustomer = _customers.FirstOrDefault(a => a.Id == id);
            if (targetCustomer == null)
                return NotFound();
            targetCustomer.Firstname = value.Firstname;
            targetCustomer.Lastname = value.Lastname;
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var targetCustomer = _customers.FirstOrDefault(a => a.Id == id);
            if (targetCustomer != null)
                _customers.Remove(targetCustomer);
            return NoContent();
        }
    }
}
