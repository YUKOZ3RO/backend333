using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;

public class CommunityController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}