using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bugtracker.DataAccessLayer;
using Bugtracker.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BugtrackerWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly BugtrackerDbContext context;

        public ProjectController(BugtrackerDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public Project Post(Project project)
        {
            var added = context.Projects.Add(project);
            context.SaveChanges();
            return added.Entity;
        }

        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return context.Projects;
        }
    }
}
