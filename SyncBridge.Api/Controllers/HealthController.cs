using Microsoft.AspNetCore.Mvc;

namespace SyncBridge.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "Healthy",
            application = "SyncBridge.Api",
            timestamp = DateTime.UtcNow
        });
    }
}