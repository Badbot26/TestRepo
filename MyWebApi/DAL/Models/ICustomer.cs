using System;

namespace MyWebApi.DAL.Models;

public interface ICustomer
{
    public Guid CustomerId { get; set; }
    public string Name { get; set; }
}