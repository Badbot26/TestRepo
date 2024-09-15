using System;
using Xunit;
using MyWebApi.BLL.Services;
using MyWebApi.DAL.Repository;
using MyWebApi.DAL.Models;
using NSubstitute;
using NSubstitute.ReturnsExtensions;

namespace MyWebApi.NSubstitute.Tests
{
    public class CustomerServiceTests
    {
        private readonly CustomerService _sut;
        private readonly ICustomerRepository _customerRepository = Substitute.For<ICustomerRepository>();

        public CustomerServiceTests()
        {
            _sut = new CustomerService(_customerRepository);
        }

        [Fact]
        public async Task GetCustomerAsync_ShouldReturnCustomer_WhenCustomerExists()
        {
            // arrange
            var customerId = Guid.NewGuid();
            var customerName = "Frank Lampard";
            var customerDto = new Customer() { CustomerId = customerId, Name = customerName };

            _customerRepository.GetCustomerAsync(customerId).Returns(customerDto);

            // act
            var customer = await _sut.GetCustomerAsync(customerId);

            // assert
            Assert.Equal(customerId, customer.CustomerId);
            Assert.Equal(customerName, customer.Name);
        }

        [Fact]
        public async Task GetCustomerAsync_ShouldReturnNull_WhenCustomerDoesNotExists()
        {
            // arrange
            _customerRepository.GetCustomerAsync(Arg.Any<Guid>()).ReturnsNull();

            // act
            var customer = await _sut.GetCustomerAsync(Guid.NewGuid());

            // assert
            Assert.Null(customer);
        }
    }
}
