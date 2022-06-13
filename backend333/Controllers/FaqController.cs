using backend333.RequestModel.cs;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
 [ApiController]
 [Route(template:"[controller]")]
public class FaqController : ControllerBase
{
   [HttpPost()]
    public ActionResult<Faq> FaqInput([FromBody] Faq faq)
    {
        return Ok(faq);
    }
}