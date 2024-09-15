using System;
using System.Collections.Generic;
using MyWebApi.DAL.Models;

namespace MyWebApi.BLL.Interfaces;

public interface ICustomerService
{
    Task<ICustomer> GetCustomerAsync(Guid customerId);
    Task<List<ICustomer>> GetCustomersAsync();
    Task AddCustomerAsync(ICustomer customer);
}