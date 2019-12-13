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
    public class UserController : ControllerBase
    {
        private readonly BugtrackerDbContext context;

        public UserController(BugtrackerDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public User Post(User user)
        {
            var added = context.Users.Add(user);
            context.SaveChanges();
            return added.Entity;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return context.Users;
        }
    }
}
