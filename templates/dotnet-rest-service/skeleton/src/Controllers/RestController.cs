using Microsoft.AspNetCore.Mvc;

namespace ${{values.namespace}}.Controllers;

[ApiController]
[Route("[controller]")]
public class RestController : ControllerBase
{
    private readonly ILogger<RestController> _logger;

    public RestController(ILogger<RestController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Get")]
    public string Get()
    {
        _logger.LogInformation("Api log made by Backstage");
        return "Hello Backstage, by ${{values.name}}";
    }
}
