using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Communication.Requests;
using MyFirstAPI.Communication.Responses;

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

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUser), StatusCodes.Status201Created)]
    public IActionResult Post([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisteredUser
        {
            Id = 1,
            Name = request.Name,
        };
        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType( StatusCodes.Status204NoContent)]
    public IActionResult Put([FromBody] RequestUpdateUserProfileJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }
}
