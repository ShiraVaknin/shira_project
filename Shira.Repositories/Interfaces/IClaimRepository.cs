﻿using Shira.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Claim = Shira.Repositories.Entities.Claim;

namespace Shira.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        Task<List<Claim>> GetAllAsync();

        Task<Claim> GetByIdAsync(int id);

        Task<Claim> AddAsync(int id, int roleId, int permissionId, EPolicy policy);

        Task<Claim> UpdateAsync(Claim claim);

        Task DeleteAsync(int id);   
        
    }
}
