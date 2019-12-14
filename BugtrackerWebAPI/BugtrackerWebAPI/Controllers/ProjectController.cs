using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bugtracker.DataAccessLayer;
using Bugtracker.DataAccessLayer.Entities;
using Bugtracker.DataAccessLayer.Models;
using Bugtracker.DataAccessLayer.Queries;
using Microsoft.AspNetCore.Mvc;

namespace BugtrackerWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectQueries _queries;

        public ProjectController(IProjectQueries queries)
        {
            _queries = queries;
        }

        [HttpPost]
        public Project Post(Project project)
        {
//            var added = _context.Projects.Add(project);
//            _context.SaveChanges();
//            return added.Entity;

            return new Project();
        }

        [HttpGet]
        public async Task<List<ProjectDto>> Get()
        {
            return await _queries.GetAll();
        }
    }
}
