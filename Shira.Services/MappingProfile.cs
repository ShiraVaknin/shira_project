using AutoMapper;
using Shira.Common.DTOs;
using Shira.Repositories.Entities;

namespace Shira.Services
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<RoleDTO, Role>().ReverseMap();
            CreateMap<ClaimDTO, Claim>().ReverseMap();
            CreateMap<PermissionDTO, Permission>().ReverseMap();
        }

    }
}