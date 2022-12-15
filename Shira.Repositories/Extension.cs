using Microsoft.Extensions.DependencyInjection;
using Shira.Repositories.Interfaces;
using Shira.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.Repositories
{
    public static class Extension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
            service.AddScoped<IRoleRepository, RoleRepository>() ;
            service.AddScoped<IPermissionRepository, PermissionRepository>() ;
            service.AddScoped<IClaimRepository, ClaimRepository>() ;  
            return service;
        }
    }
}
