using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly ILogger<MessageController> _logger;

    public MessageController(ILogger<MessageController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        return "sample message";
    }

    [HttpPost]
    public void Post()
    {

    }
}
