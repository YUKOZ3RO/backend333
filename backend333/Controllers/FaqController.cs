using backend333.RequestModel;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
 [ApiController]
 [Route(template:"[controller]")]
public class FaqController : ControllerBase
{
    
    public FaqController(DbContext333 dbContext333)
    {
        _dbContext333 = dbContext333;
    }
    private readonly DbContext333 _dbContext333;
    [HttpGet()]
    public ActionResult get()
    { 
        var result= _dbContext333.Faq.Where(i=> i.Active).ToList();
        return Ok(result);
    }
   [HttpPost(template: "Approve")]
   public async Task<ActionResult<Faq>> FaqActive([FromBody] FaqActive faq)
    {
        var result = _dbContext333.Faq.First(i => i.Id == faq.Id);
        result.Active = true;
        await _dbContext333.SaveChangesAsync();
        return Ok(faq);
    }
    [HttpPost("faqInput")]
    public async Task<ActionResult<Faq>> FaqInput([FromBody] Faq faq)
    {
        _dbContext333.Add(faq);
        await _dbContext333.SaveChangesAsync();
        return Ok(faq);
    }

   
}

