using Test_Assignment_3.DataAccess;
using Test_Assignment_3.DTO;
using Test_Assignment_3.Models;

namespace Test_Assignment_3.Services
{



    public interface ICustomerService
    {
        public Task<Customer> CreateCustomer(CustomerDTO createCustomerDTO);

        public Task<Customer> DeleteCustomerById(int customerId);

    }

    public class CustomerService : ICustomerService
    {
        private readonly ICustomerStorage _customerStorage;

        public CustomerService(ICustomerStorage customerStorage)
        {
            _customerStorage = customerStorage;
        }
        public async Task<Customer> CreateCustomer(CustomerDTO createCustomerDTO)
        {
            try
            {
                return await _customerStorage.CreateCustomer(
                    new Customer
                    {
                        FirstName = createCustomerDTO.FirstName,
                        LastName = createCustomerDTO.LastName,
                        Birthdate = createCustomerDTO.Birthdate
                    });
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Customer> DeleteCustomerById(int customerId)
        {
            return await _customerStorage.DeleteCustomer(customerId);
        }

        
    }
}
