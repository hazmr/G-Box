using Microsoft.AspNetCore.Mvc;

namespace G_Box.Controllers;

public class HomeController: Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }
    [Route("/Home/Error")]
    public IActionResult Error()
    {
        return View();
    }
}