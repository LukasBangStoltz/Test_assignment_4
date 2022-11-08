using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test_Assignment_3.DTO;
using Test_Assignment_3.Models;
using Test_Assignment_3.Services;

namespace Test_Assignment_3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [Route("add")]
        [HttpPost]
        public async Task<CustomerDTO> Createcustomer(CustomerDTO createCustomerDTO)
        {
            Customer customer =  await _customerService.CreateCustomer(createCustomerDTO);
            return new CustomerDTO { FirstName = customer.FirstName, LastName = customer.LastName, Birthdate = customer.Birthdate };
        }
        [Route("delete")]
        [HttpPost]
        public async Task<CustomerDTO> DeleteCustomer(int customerId)
        {
            Customer customer =  await _customerService.DeleteCustomerById(customerId);
            return new CustomerDTO { FirstName = customer.FirstName, LastName = customer.LastName, Birthdate = customer.Birthdate };
        }
        

    }
}
