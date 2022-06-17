using backend333.RequestModel;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
[ApiController]
[Route("[controller]")]

public  class ContactUsController : ControllerBase
{
    private readonly DbContext333 _dbContext333;
  
    public ContactUsController(DbContext333 dbContext333)
    {
        _dbContext333 = dbContext333;
    }

    [HttpGet()]
    public ActionResult get()
    {
        var result=_dbContext333.ContactUs.ToList();
        return Ok(result);
    }
    [HttpPost(template: "contactInput")]

     public ActionResult<ContactUs> ContactUsInput([FromBody] ContactUs contactUs)
     {
         _dbContext333.Add(contactUs);
         _dbContext333.SaveChanges();
        return Ok(contactUs);
    }
}
