using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Entities;

namespace MyFirstAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DeviceController : MyFirstApiController
{
    [HttpGet]
    public IActionResult Get()
    {
        var device = new Device();

        var laptop = new Laptop();

        var model = laptop.GetModel();

        return Ok(model);
    }
}
