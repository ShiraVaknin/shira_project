using Shira.Common.DTOs;
using Shira.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.Services.Interfaces
{
    public interface IClaimService
    {
        Task<List<ClaimDTO>> GetAllAsync();

        Task<ClaimDTO> GetByIdAsync(int id);

        Task<ClaimDTO> AddAsync(int id, int roleId, int permissionId, EPolicy policy);

        Task<ClaimDTO> UpdateAsync(ClaimDTO claim);

        Task DeleteAsync(int id);
    }
}
