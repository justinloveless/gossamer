using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactsController : ControllerBase
{
    private readonly ILogger<ContactsController> _logger;

    public ContactsController(ILogger<ContactsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetContact")]
    public string Get()
    {
        return "sample contact";
    }
}
