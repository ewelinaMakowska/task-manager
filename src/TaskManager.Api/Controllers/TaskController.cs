using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    [HttpGet]
    public IActionResult GetTasks()
    {
        var tasks = new[]
        {
            "Learn ASP.NET Core",
            "Build authentication",
            "Add PostgreSQL"
        };

        return Ok(tasks);
    }

}