using System;
using System.Collections.Generic;
using MyWebApi.DAL.Models;

namespace MyWebApi.DAL.Repository;

public interface ICustomerRepository
{
    Task<ICustomer> GetCustomerAsync(Guid customerId);
    Task<List<ICustomer>> GetCustomersAsync();
    Task AddCustomerAsync(ICustomer customer);
}