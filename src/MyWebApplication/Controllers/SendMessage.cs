using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SendMessage : ControllerBase
{
    private readonly DaprClient _daprClient;

    public SendMessage(DaprClient daprClient)
    {
        _daprClient = daprClient;
    }
    
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        _daprClient.PublishEventAsync("messagebus", "message", "Hello World!");
        return Ok("Hello World!");
    }
}