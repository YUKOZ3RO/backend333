using backend333.RequestModel;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers;
[ApiController]
[Route("[controller]")]
public class CommunityController : ControllerBase
{private readonly DbContext333 _dbContext333;

    public CommunityController(DbContext333 dbContext333)
    {
        _dbContext333 = dbContext333;
    }

[HttpGet()]
public ActionResult get()
{
    var result= _dbContext333.Community.ToList();
    return Ok(result);
}

[HttpPost("Approve")]

public async Task<ActionResult<CommunityActive>> CommunityActive([FromBody] CommunityActive community)
{
    var result = _dbContext333.Community.First(i => i.Id == community.Id);
    result.Active = true;
    await _dbContext333.SaveChangesAsync();
    return Ok(result);
}
    [HttpPost("communityInput")]

    public async Task<ActionResult<Community>> CommunityInput([FromBody] Community community)
    {
        _dbContext333.Add(community);
        await _dbContext333.SaveChangesAsync();
        return Ok(community);
    }
}
