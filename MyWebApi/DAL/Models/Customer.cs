using System;

namespace MyWebApi.DAL.Models;

public class Customer
{
    public Guid CustomerId { get; set; }
    public string Name { get; set; }
}