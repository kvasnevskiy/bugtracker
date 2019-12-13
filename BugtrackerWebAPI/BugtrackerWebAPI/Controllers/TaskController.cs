using System.Collections.Generic;
using Bugtracker.DataAccessLayer;
using Bugtracker.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BugtrackerWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly BugtrackerDbContext context;

        public TaskController(BugtrackerDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public Task Post(Task task)
        {
            var added = context.Tasks.Add(task);
            context.SaveChanges();
            return added.Entity;
        }

        [HttpGet]
        public IEnumerable<Task> Get()
        {
            return context.Tasks;
        }
    }
}