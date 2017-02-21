using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.DataAccess;

namespace TodoApp.Controllers{
    [Route("api/[controller]")]
    public class TaskController: Controller {
          
        private ITasksRepository repository;
        public TaskController(){
            repository = new TasksRepository();
        }
        [HttpGet]
        public List<Task> GetAll()
        {
            return repository.All();
        }

        [HttpGet("{id}", Name = "GetTask")]
        public IActionResult GetById(int id)
        {
            var task = repository.Get(id);
            if (task == null)
            {
                return NotFound();
            }
            return new ObjectResult(task);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Task task)
        {
            if (task == null)
            {
                return BadRequest();
            }
            task.Id = repository.All().Count + 1;
            repository.Add(task);
            return CreatedAtRoute("GetTask", new { controller = "Task", id = task.Id }, task);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}