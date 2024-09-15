using System;
using System.Collections.Generic;
using MyWebApi.DAL.Models;

namespace MyWebApi.BLL.Interfaces;

public interface ICustomerService
{
    Task<Customer> GetCustomerAsync(Guid customerId);
    Task<List<Customer>> GetCustomersAsync();
    Task AddCustomerAsync(Customer customer);
}