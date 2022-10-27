using Microsoft.AspNetCore.Mvc;
using wa_todolist_backend.Models;

namespace wa_todolist_backend.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<TaskModel>> BuscarTodasTasks()
        {
            return Ok();
        }
    }
}