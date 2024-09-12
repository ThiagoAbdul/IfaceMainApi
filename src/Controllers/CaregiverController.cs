using IfaceMainApi.Models.DTOs;
using IfaceMainApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IfaceMainApi.Models.Entities;
using IfaceMainApi.Models.Templates;
using IfaceMainApi.src.Models.DTOs;


namespace IfaceMainApi.src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaregiverController(CaregiverService caregiverService) : ControllerBase
    {
        private readonly CaregiverService _caregiverService = caregiverService;
        [HttpPost]
        public async Task<IActionResult> CreateCaregiver([FromBody] CreateCaregiverRequest request)
        {
            Result<CaregiverResponse> result = await _caregiverService.CreateCaregiver(request);
            if(result.HasError())
            {
                return BadRequest(result.ErrorMessage);
            }

            return Ok(result.Value);
        }

        [HttpGet]
        public async Task<IActionResult> GetCaregiver()
        {
            Guid mockAuthId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6");
            Result<CaregiverResponse> result = await _caregiverService.FindCaregiverByAuthId(mockAuthId);
            
            if (result.HasError())
                return BadRequest(result.ErrorMessage);
            
            return Ok(result.Value);    
        }

        [HttpGet("PersonWithAlzheimerDisease")]
        public async Task<IActionResult> GetAllPwads()
        {
            Guid mockAuthId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6");
            var result = await _caregiverService.GetAllPwadsByCaregiver(mockAuthId);

            if(result.HasError())
                return BadRequest(result.ErrorMessage);

            return Ok(result.Value);  

        }
    }
}
