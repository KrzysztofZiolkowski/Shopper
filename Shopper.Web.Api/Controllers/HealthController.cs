using Microsoft.AspNetCore.Mvc;

namespace Shopper.Web.Api.Controllers;

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Shopper API service runs successfully");
    }
}