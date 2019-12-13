using System;
using System.Collections.Generic;
using System.Text;

namespace Bugtracker.DataAccessLayer.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public User User { get; set; } 
        public Project Project { get; set; }
    }
}
