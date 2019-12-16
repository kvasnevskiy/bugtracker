using System.Collections.Generic;

namespace Bugtracker.DataAccessLayer.Models
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TaskDto> Tasks { get; set; }
        public ICollection<UserProjectDto> UserProjects { get; set; }
    }
}