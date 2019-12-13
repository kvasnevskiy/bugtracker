using System;
using System.Collections.Generic;
using System.Text;

namespace Bugtracker.DataAccessLayer.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<UserProject> UserProjects { get; set; }
    }
}
