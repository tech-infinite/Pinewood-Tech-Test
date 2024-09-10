using CustomersAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomersAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private static List<Customer> customersList = new List<Customer>
        {
            new Customer
            {
                CustomerID = 1,
                Name = "Mike Smith",
                Address = "1 Wall Street",
                Email = "msmith@gmail.com",
                Phone = "0800 750 2219"
            },
            new Customer
            {
                CustomerID = 2,
                Name = "John Hill",
                Address = "10 Swiss Cottage Street",
                Email = "jsmith@gmail.com",
                Phone = "0800 750 2219"
            },
            new Customer
            {
                CustomerID = 3,
                Name = "Tom Davis",
                Address = "15 Logan Road",
                Email = "tdavis@gmail.com",
                Phone = "0800 750 2219"
            },
            new Customer
            {
                CustomerID = 4,
                Name = "Will Brown",
                Address = "12 Forest Street",
                Email = "willb@yahoo.com",
                Phone = "0800 750 2219"
            },
            new Customer
            {
                CustomerID = 5,
                Name = "Jess Smith",
                Address = "20 Fenchurch Road",
                Email = "jsmith@yahoo.com",
                Phone = "0800 750 2219"
            },
            new Customer
            {
                CustomerID = 6,
                Name = "Kate Mills",
                Address = "25 Greenhill Lane",
                Email = "jnmiills@gmail.com",
                Phone = "0800 750 2219"
            },

        };

        [HttpGet]
        public ActionResult<List<Customer>> GetCustomers()
        {
            return Ok(customersList);
        }

        [HttpPost]  // Adds a new customer to the list
        public ActionResult<List<Customer>> AddCustomer(Customer customer)
        {
            customersList.Add(customer);
            return Ok(customersList);
        }

        [HttpPut("{customerID}")]
        public ActionResult<List<Customer>> EditCustomer(Customer newCustomer)
        {
            var currentCustomer = customersList.Find(x => x.CustomerID == newCustomer.CustomerID);
            if (currentCustomer == null)
            {
                return NotFound("The entered customer doesn't exist");
            }

            currentCustomer.CustomerID = newCustomer.CustomerID;
            currentCustomer.Name = newCustomer.Name;
            currentCustomer.Address = newCustomer.Address;
            currentCustomer.Email = newCustomer.Email;
            currentCustomer.Phone = newCustomer.Phone;

            return Ok(currentCustomer);
        }

        [HttpDelete("{customerID}")]
        public ActionResult<List<Customer>> DeleteCustomer(int customerID)
        {
            var customer = customersList.FirstOrDefault(c => c.CustomerID == customerID);
            if (customer == null)
            {
                return NotFound("The entered customer does not exist");
               
            }

            customersList.Remove(customer);
            return Ok(customersList);
        }
    }
}
