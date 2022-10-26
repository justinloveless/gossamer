using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class NotificationController : ControllerBase
{
    private readonly ILogger<NotificationController> _logger;

    public NotificationController(ILogger<NotificationController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetNotification")]
    public string Get()
    {
        return "sample notification";
    }
}
