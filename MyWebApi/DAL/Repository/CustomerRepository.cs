using System;
using System.Collections.Generic;
using MyWebApi.DAL.Models;

namespace MyWebApi.DAL.Repository;

public class CustomerRepository : ICustomerRepository
{
    private static List<Customer> _customers;

    static CustomerRepository()
    {
        // setup a simulation of the data
        _customers = new List<Customer>()
        {
            new Customer() { CustomerId = Guid.NewGuid(), Name = "John Smith" },
            new Customer() { CustomerId = Guid.NewGuid(), Name = "Jane Doe" },
            new Customer() { CustomerId = Guid.NewGuid(), Name = "Anne Templeton" }
        };
    }

    public async Task<Customer> GetCustomerAsync(Guid customerId)
    {
        // simulate time taken to retrieve from db
        await Task.Delay(500);

        var customer = _customers.FirstOrDefault(c => c.CustomerId == customerId);
        return customer;
    }

    public async Task<List<Customer>> GetCustomersAsync()
    {
        // simulate time taken to retrieve from db
        await Task.Delay(250);

        return _customers;
    }

    public async Task AddCustomerAsync(Customer customer)
    {
        // simulate time taken to insert into db
        await Task.Delay(750);

        _customers.Add(customer);
    }
}