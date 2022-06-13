using backend333.Controllers.RequestModel.cs;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
[ApiController]
[Route("[controller]")]
public  class ContactUsController : ControllerBase
{
    [HttpPost()]
     public ActionResult<ContactUs> ContactUsInput([FromBody] ContactUs contactUs)
     {
        return Ok(contactUs);
    }
}