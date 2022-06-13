using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
 [ApiController]
 [Route(template:"[controller]")]
public class Faq : Controller
{
   [HttpPost()]
    public IActionResult Index([FromBody] Faq faq)
    {
        return Ok();
    }
}