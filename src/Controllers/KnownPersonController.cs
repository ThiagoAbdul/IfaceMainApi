using IfaceMainApi.Services;
using IfaceMainApi.src.Models.DTOs.In;
using Microsoft.AspNetCore.Mvc;

namespace IfaceMainApi.src.Controllers;
[Route("api/[controller]")]
[ApiController]
public class KnownPersonController(KnownPersonService knownPersonService) : ControllerBase
{
    private readonly KnownPersonService _knownPersonService = knownPersonService;
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var response = await _knownPersonService.GetKnownPersonById(id);

        if(response.HasError())
            return BadRequest(response.ErrorMessage);

        return Ok(response.Value);
    }

    [HttpPost("{id}/AddImage")]
    public async Task<IActionResult> AddImage([FromRoute]Guid id, [FromForm] AddImageForm form)
    {
        var response = await _knownPersonService.AddImage(id, form.Embedding, form.File);

        if(response.HasError())
            return BadRequest(response.ErrorMessage);

        return Ok(response.Value);
    }
}
