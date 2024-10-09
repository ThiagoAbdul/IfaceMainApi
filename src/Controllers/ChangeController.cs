using IfaceMainApi.src.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IfaceMainApi.src.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChangeController(ChangeService changeService) : ControllerBase
{

    [HttpGet("Pwad/{id}")]
    public async Task<IActionResult> GetChangesForPwad([FromRoute] Guid id)
    {
        var response = await changeService.GetChangesForPwad(id);

        if(response.HasError())
            return BadRequest(response.ErrorMessage);

        return Ok(response.Value);
    }

    [HttpGet("Pwad/{id}/All")]
    public async Task<IActionResult> GetAllChangesForPwad([FromRoute] Guid id)
    {
        var response = await changeService.GetChangesForPwad(id, true);

        if (response.HasError())
            return BadRequest(response.ErrorMessage);

        return Ok(response.Value);
    }

    [HttpPost("Pwad/{id}/SyncAll")]
    public async Task<IActionResult> SyncAll([FromRoute] Guid id)
    {
        await changeService.SyncAll(id);
        return NoContent();
    }
}
