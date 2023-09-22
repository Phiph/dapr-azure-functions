using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers;

public class SendMessage : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}