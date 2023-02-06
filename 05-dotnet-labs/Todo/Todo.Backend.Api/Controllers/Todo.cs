using Microsoft.AspNetCore.Mvc;
using Todo.Backend.Api.Models;
using Todo.Backend.Api.Mock;

namespace Todo.Backend.Api.Controllers
{
      [ApiController]
      [Route("[controller]")]
      public class TodoController : ControllerBase
      {
            private readonly ILogger<TodoController> _logger;
            public TodoController(ILogger<TodoController> logger)
            {
                  _logger = logger;
            }
            [HttpGet(Name="GetItems")]
            public ActionResult<List<DTOTodoItem>> GetMockData()
            {
                  return Ok(GetMockData().ToList<DTOTodoItem>());
            }
      }
}