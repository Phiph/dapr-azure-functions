using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SendMessage : ControllerBase
{
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Hello World!");
    }
}