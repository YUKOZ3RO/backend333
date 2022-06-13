using backend333.RequestModel.cs;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
[ApiController]
[Route("[controller]")]
public class CommunityController : Controller
{[HttpPost()]
    
    public ActionResult<Community> CommunityInput([FromBody] Community community)
    {
        return Ok(community);
    }
}