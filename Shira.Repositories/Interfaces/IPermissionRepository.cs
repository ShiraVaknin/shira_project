using Shira.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.Repositories.Interfaces
{
    public interface IPermissionRepository
    {
        Task<List<Permission>> GetAllAsync();

        Task<Permission> GetByIdAsync(int id);

        Task<Permission> AddAsync(int id, string name, string decraption);

        Task<Permission> UpdateAsync(Permission permissionole);

        Task DeleteAsync(int id);
    }
}
