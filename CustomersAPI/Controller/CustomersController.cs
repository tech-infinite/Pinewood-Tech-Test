using CustomersAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomersAPI.Controller
{
    [ApiController]
    [Route("api/[controller")]
    public class CustomersController : ControllerBase
    {
        private static List<Customer> customersList = new List<Customer>
        {
            new Customer
            {
                CustomerID = 1,
                Name = "Mike Smith",
                Address = "10 Wall Street",
                Email = "msmith@gmail.com",
                Phone = "0800 750 2219"
            },
            new Customer
            {
                CustomerID = 2,
                Name = "John Hill",
                Address = "10 Wall Street",
                Email = "jsmith@gmail.com",
                Phone = "0800 750 2219"
            },
            new Customer
            {
                CustomerID = 3,
                Name = "Tom Davis",
                Address = "10 Wall Street",
                Email = "tdavis@gmail.com",
                Phone = "0800 750 2219"
            },
            new Customer
            {
                CustomerID = 4,
                Name = "Will Brown",
                Address = "10 Wall Street",
                Email = "willb@yahoo.com",
                Phone = "0800 750 2219"
            },
            new Customer
            {
                CustomerID = 5,
                Name = "Jess Smith",
                Address = "10 Wall Street",
                Email = "jsmith@yahoo.com",
                Phone = "0800 750 2219"
            },
            new Customer
            {
                CustomerID = 6,
                Name = "Kate Mills",
                Address = "10 Wall Street",
                Email = "jnmiills@gmail.com",
                Phone = "0800 750 2219"
            },

        };

        [HttpGet]
        public ActionResult<List<Customer>> GetCustomers()
        {
            return Ok(customersList);
        }

        [HttpPost]
        public IActionResult AddCustomer()
        {

        }

        [HttpPut]
        public IActionResult EditCustomer()
        {

        }

        [HttpDelete]
        public IActionResult DeleteCustomer()
        {

        }
    }
}
