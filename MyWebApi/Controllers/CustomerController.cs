using Microsoft.AspNetCore.Mvc;
using MyWebApi.BLL.Interfaces;
using MyWebApi.DAL.Models;

namespace MyWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _customerService.GetCustomersAsync());
    }

    [HttpGet("GetCustomer")]
    public async Task<IActionResult> Get([FromBody] Guid customerId)
    {
        return Ok(await _customerService.GetCustomerAsync(customerId));
    }

    [HttpPost]
    public async Task<IActionResult> AddCustomer([FromBody] string name)
    {
        Customer customer = new Customer() { Name = name, CustomerId = Guid.NewGuid() };
        await _customerService.AddCustomerAsync(customer);

        return CreatedAtAction(nameof(AddCustomer), customer);
    }
}