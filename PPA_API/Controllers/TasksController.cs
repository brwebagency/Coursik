using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PPA_Core;
using PPA_DB;

namespace PPA_API.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : Controller {
        private readonly ILogger<TasksController> _logger;
        private ITaskServices _taskServices;
        
        public TasksController(ILogger<TasksController> logger, ITaskServices taskServices) {
            _logger = logger;
            _taskServices = taskServices;
        }

        [HttpGet("{id}")]
        public IActionResult GetTasks(int id) {
            return Ok(_taskServices.GetTasks(id));
        }

        [HttpPost("create")]
        public IActionResult CreateTask(Task task) {
            return Ok(_taskServices.CreateTask(task));
        }

        [HttpPost("update")]
        public IActionResult UpdateTask(Task task) {
            return Ok(_taskServices.UpdateTask(task));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id) {
            return Ok(_taskServices.DeleteTask(id));
        }
    }
}