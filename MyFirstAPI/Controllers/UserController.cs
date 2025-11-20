using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Get([FromRoute] int id)
    {
        var response = new User
        {
            Id = 1,
            Age = 21,
            Name = "Pedro",
        };
        return Ok(response);
    }
}
