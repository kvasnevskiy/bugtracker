using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Bugtracker.DataAccessLayer.Entities
{
    public class User
    {
         public int Id { get; set; }
         public string Name { get; set; }
         public string Password { get; set; }
         public UserRole Role { get; set; }
         public ICollection<UserProject> UserProjects { get; set; }
    }
}
