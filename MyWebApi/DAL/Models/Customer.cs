using System;

namespace MyWebApi.DAL.Models;

public class Customer : ICustomer
{
    public Guid CustomerId { get; set; }
    public string Name { get; set; }
}