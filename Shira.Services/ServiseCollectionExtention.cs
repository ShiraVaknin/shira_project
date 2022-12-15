using Microsoft.Extensions.DependencyInjection;
using Shira.Services.Interfaces;
using Shira.Services.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.Services
{
    public static class ServiseCollectionExtention
    {
        public static IServiceCollection AddServises(this IServiceCollection service)
        {
            service.AddScoped<IClaimService, ClaimServise>();
            service.AddScoped<IRoleService, RoleService>(); 
            service.AddScoped<IPermissionService, PermissionService>();
            service.AddAutoMapper(typeof(MappingProfile));
            return service; 
        }
    }
}
