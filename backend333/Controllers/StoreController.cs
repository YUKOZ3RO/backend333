using backend333.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
[ApiController]
[Route(template:"[controller]")]
public class StoreController : ControllerBase

{private readonly DbContext333 _dbContext333;
    public StoreController(DbContext333 dbContext333)
    {
        _dbContext333 = dbContext333;
    }
    [HttpGet]
    public ActionResult get()
    {
    var result=    _dbContext333.Store.ToList();
        return Ok(result);
    }
  [HttpPost(template: "StoreInput")]
    public ActionResult<Store> StoreInput([FromBody] Store store)
    {
        _dbContext333.Add(store);
        _dbContext333.SaveChanges();
        return Ok(store);
    }
}