using Shira.Common.DTOs;
using Shira.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.Services.Interfaces
{
    public interface IPermissionService
    {
        Task<List<PermissionDTO>> GetAllAsync();

        Task<PermissionDTO> GetByIdAsync(int id);

        Task<PermissionDTO> AddAsync(int id, string name, string decraption);

        Task<PermissionDTO> UpdateAsync(PermissionDTO permissionole);

        Task DeleteAsync(int id);
    }
}
