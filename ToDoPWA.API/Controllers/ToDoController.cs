using Microsoft.AspNetCore.Mvc;

namespace ToDoPWA.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDoController : ControllerBase
{
    private readonly ILogger<ToDoController> _logger;

    public ToDoController(ILogger<ToDoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAllToDoItems")]
    public IEnumerable<int> Get()
    {
        return [];
    }
}