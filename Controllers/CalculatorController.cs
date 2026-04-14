using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dto;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult Add([FromBody] AddDto request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request payload.");
            }
            double result = request.Number1 + request.Number2;
            return Ok(new { Result = result });
        }
    }
}
