using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.DataAccess;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    public class TaskController: Controller
    {
        private ITasksRepository repository;
        public TaskController(ITasksRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        //GET /api/Task
        public List<Task> GetAll()
        {
            return repository.All();
        }

        [HttpGet("{id}")]
        //GET /api/Task/1
        public IActionResult GetById(int id)
        {
            var task = repository.Get(id);
            if (task == null)
            {
                return NotFound();
            }
            return new ObjectResult(task);
        }

        //POST /api/Task
        [HttpPost]
        public bool Create([FromBody] Task task)
        {
            bool created = true;
            if (task == null)
                return !created;
            task.Id = repository.All().Count + 1;
            repository.Add(task);
            return created;
        }

        //DELETE /api/Task/6
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}