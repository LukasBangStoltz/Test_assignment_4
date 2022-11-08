using FluentAssertions;
using Moq;
using Test_Assignment_3.DataAccess;
using Test_Assignment_3.DTO;
using Test_Assignment_3.Models;
using Test_Assignment_3.Services;

namespace Test
{
    public class CustomerServiceTest
    {
        private  Mock<ICustomerStorage> _customerStorageMock;
        private  ICustomerService _customerService;


        [SetUp]
        public void Setup()
        {
            _customerStorageMock = new Mock<ICustomerStorage>();
            _customerService = new CustomerService(_customerStorageMock.Object);

        }

        [Test]
        
        public async Task CreateCustomer_Creates_Customer()
        {
            var expected = new Customer { FirstName = "jens", LastName = "andersen", Birthdate= new DateTime() };
            _customerStorageMock.Setup(x => x.CreateCustomer(expected)).ReturnsAsync(expected);
            var mocked = await _customerService.CreateCustomer(new CustomerDTO { FirstName = "jens", LastName = "andersen", Birthdate = new DateTime() });
           // mocked.FirstName.Should().BeEquivalentTo(expected.FirstName);
            //expected.Should().BeEquivalentTo(mocked);
        }

        [Test]
        public async Task DeleteCustomer_Deletes_Customer()
        {
            var expected = new Customer { FirstName = "jens", LastName = "andersen" };
            _customerStorageMock.Setup(x => x.DeleteCustomer(It.IsAny<int>())).ReturnsAsync(expected);
            var mocked = await _customerService.DeleteCustomerById(1);



            _customerStorageMock.Verify(mock => mock.DeleteCustomer(It.Is<int>(id => id ==1)));
            //Assert.That(mocked, Is.EqualTo(expected));
        }

        
    }
}