using Microsoft.AspNetCore.Mvc;

namespace somchai_bn.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthCheckController : ControllerBase
{
    private readonly ILogger<HealthCheckController> _logger;

    public HealthCheckController(ILogger<HealthCheckController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "healthcheck")]
    public string HealthCheck()
    {
        return "I'm Ok.";
    }
}
