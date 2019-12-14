using System.Collections.Generic;
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
            #region exemple
            var zalupa = new Project();
            var zalupaDto = _mapper.Map<ProjectDto>(zalupa);
            #endregion
            
            return await _context.Projects.ProjectTo<ProjectDto>(_mapper.ConfigurationProvider).ToListAsync();
        }
    }
}