using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Bugtracker.DataAccessLayer.Entities;
using Bugtracker.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.TypeMapping;

namespace Bugtracker.DataAccessLayer.Queries
{ 
    public class ProjectQueries: IProjectQueries
    {

        private readonly BugtrackerDbContext _context;
        private readonly IMapper _mapper;
            
        public ProjectQueries(BugtrackerDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ProjectDto>> GetAll()
        {
            var projects = await _context.Set<Project>().AsNoTracking().ToListAsync();
            return _mapper.Map<List<ProjectDto>>(projects);
        }
    }
}