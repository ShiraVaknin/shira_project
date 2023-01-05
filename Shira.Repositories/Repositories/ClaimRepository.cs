using Microsoft.EntityFrameworkCore;
using Shira.Repositories.Entities;
using Shira.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.Repositories.Repositories
{
    public class ClaimRepository: IClaimRepository
    {
        private readonly IContext _context;

        public ClaimRepository(IContext context)
        { 
            _context = context; 
        }

        public async Task<Claim> AddAsync(int id, int roleId, int permissionId, EPolicy policy)
        {
            Claim claim = new Claim { Id = id, RoleId = roleId, PermissionId = permissionId, Policy = policy };
            _context.Claims.Add(claim);
            await _context.SaveChangesAsync();
            return claim;   
        }

        public async Task DeleteAsync(int id)
        {
            Claim claim = await GetByIdAsync(id);
            _context.Claims.Remove(claim);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Claim>> GetAllAsync()
        {
            return await _context.Claims.ToListAsync();    
        }

        public async Task<Claim> GetByIdAsync(int id)
        {
            return await _context.Claims.FindAsync(id); 
        }

        public async Task<Claim> UpdateAsync(Claim claim)
        {
            var c = await GetByIdAsync(claim.Id);
            claim.RoleId = c.RoleId;
            claim.PermissionId = c.PermissionId;
            await _context.SaveChangesAsync();
            return claim;
        }
    }


}
