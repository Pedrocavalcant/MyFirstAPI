using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Get()
    {
        var response = new User
        {
            Age = 21,
            Name = "Pedro",
            Sobrenome = "Cavalcante",
            Irmaos = 3,
            Mae = "Maria Aparecida da Silva Cavalcante"
        };
        return Ok(response);
    }
}
