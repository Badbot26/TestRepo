using System;
using System.Collections.Generic;
using MyWebApi.DAL.Repository;
using MyWebApi.BLL.Interfaces;
using MyWebApi.DAL.Models;

namespace MyWebApi.BLL.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<Customer> GetCustomerAsync(Guid customerId)
    {
        return await _customerRepository.GetCustomerAsync(customerId);
    }

    public async Task<List<Customer>> GetCustomersAsync()
    {
        return await _customerRepository.GetCustomersAsync();
    }

    public async Task AddCustomerAsync(Customer customer)
    {
        await _customerRepository.AddCustomerAsync(customer);
    }
}