using IfaceMainApi.Models.Templates;
using IfaceMainApi.src.Models.DTOs.In;
using IfaceMainApi.src.Models.DTOs.Out;
using IfaceMainApi.src.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IfaceMainApi.src.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PwadController(PwadService pwadService) : ControllerBase
{
    private readonly PwadService _pwadService = pwadService;
    [HttpPost]
    public async Task<IActionResult> RegisterPwad([FromBody] CreatePwadRequest request)
    {
        Guid caregiverId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6");
        Result<PwadMinResponse> result = await _pwadService.Create(request, caregiverId);

        if (result.HasError())
            return BadRequest(result.ErrorMessage);

        return Created($"{result.Value.Id}", result.Value);

    }

    [HttpPost("RegisterDevice")]
    public async Task<IActionResult> GetPwad([FromBody] RegisterPwadDeviceRequest request)
    {
        Result<PwadMinResponse> result = await _pwadService.RegisterDevice(request);

        if (result.HasError()) 
            return BadRequest(result.ErrorMessage);

        return Ok(result.Value);
    }

    [HttpPost("{pwadId}/AddKnownPerson")]
    public async Task<IActionResult> AddKnowPerson(
        [FromRoute] Guid pwadId, [FromBody] CreateKnowPersonRequest request)
    {
        var response = await _pwadService.AddKownPerson(pwadId, request); 

        if(response.HasError())
            return BadRequest(response.ErrorMessage);

        return Created($"/api/KnownPerson/{response.Value.Id}", response.Value);
    }

    [HttpGet("{pwadId}/KnownPersons")]
    public async Task<IActionResult> GetAllKnownPersonsByPwadId([FromRoute] Guid pwadId)
    {
        var response = await _pwadService.GetAllKnownPersonsByPwadId(pwadId);

        if(response.HasError())
            return BadRequest(response.ErrorMessage);


        return Ok(response.Value);

    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var response = await _pwadService.GetPwadById(id);

        if(response.HasError())
            return BadRequest(response.ErrorMessage);

        return Ok(response.Value);
    }

}

