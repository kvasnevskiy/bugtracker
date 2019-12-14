using System.Collections.Generic;
using System.Threading.Tasks;
using Bugtracker.DataAccessLayer.Models;

namespace Bugtracker.DataAccessLayer.Queries
{
    public interface IProjectQueries
    {
        Task<List<ProjectDto>> GetAll();
    }

}