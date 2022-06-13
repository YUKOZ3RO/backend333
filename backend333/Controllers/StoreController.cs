using backend333.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
[ApiController]
[Route(template:"[controller]")]
public class StoreController : ControllerBase

{
  [HttpPost]
    public ActionResult<Store> StoreInput([FromBody] Store store)
    {
        return Ok();
    }
}