using System;
using System.Collections.Generic;
using System.Text;

namespace Bugtracker.DataAccessLayer.Entities
{
    public class UserProject
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
