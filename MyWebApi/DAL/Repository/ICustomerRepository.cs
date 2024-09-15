using System;
using System.Collections.Generic;
using MyWebApi.DAL.Models;

namespace MyWebApi.DAL.Repository;

public interface ICustomerRepository
{
    Task<Customer> GetCustomerAsync(Guid customerId);
    Task<List<Customer>> GetCustomersAsync();
    Task AddCustomerAsync(Customer customer);
}