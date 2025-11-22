using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MyFirstApiController : ControllerBase
{
    public string Autor { get; set; } = "Pedro Cavalcante";
}
