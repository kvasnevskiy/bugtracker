using AutoMapper;
using Bugtracker.DataAccessLayer.Entities;
using Bugtracker.DataAccessLayer.Models;

namespace BugtrackerWebAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Project, ProjectDto>();
        }
    }
}