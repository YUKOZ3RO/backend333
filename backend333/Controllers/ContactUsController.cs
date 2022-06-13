using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
[ApiController]
[Route("[Controller]")]
public class ContactUsController : ControllerBase
{
    // GET
    [HttpGet()]
    public IActionResult Index()
    {
        return Ok();
    }
}