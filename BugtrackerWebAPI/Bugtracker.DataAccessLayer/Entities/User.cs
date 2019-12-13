using System;
using System.Collections.Generic;
using System.Text;

namespace Bugtracker.DataAccessLayer.Entities
{
    public class User
    {
         public int Id { get; set; }
         public string Name { get; set; }
         public UserRole Role { get; set; }
         public Project[] Projects { get; set; }
    }
}
