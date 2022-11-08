using Test_Assignment_3.Context;
using Test_Assignment_3.Models;

namespace Test_Assignment_3.DataAccess
{

    public interface ICustomerStorage
    {
        
        public Task<Customer> CreateCustomer(Customer customer);
        public Task <Customer> DeleteCustomer(int customerId);
    }

    public class CustomerStorage : ICustomerStorage
    {
        private readonly DBApplicationContext _dbContext;

        public CustomerStorage(DBApplicationContext dBApplicationContext)
        {
            _dbContext = dBApplicationContext;
        }
        public async Task<Customer> CreateCustomer(Customer customer)
        {
            try
            {
                await _dbContext.Customers.AddAsync(customer);
                await _dbContext.SaveChangesAsync();
                return customer;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Customer> DeleteCustomer(int customerId)
        {
            try
            {
               Customer customer = _dbContext.Customers.Find(customerId);
                _dbContext.Remove(customer);
                await _dbContext.SaveChangesAsync();
                return customer;
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
