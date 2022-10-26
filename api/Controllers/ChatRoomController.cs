using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class ChatRoomController : ControllerBase
{
    private readonly ILogger<ChatRoomController> _logger;

    public ChatRoomController(ILogger<ChatRoomController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetChatRoom")]
    public string Get()
    {
        return "sample chat room";
    }
}
