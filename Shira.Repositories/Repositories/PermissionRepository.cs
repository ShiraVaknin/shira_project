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
    public class PermissionRepository : IPermissionRepository   
    {
        private readonly IContext _context;

        public PermissionRepository(IContext context)
        {
            _context = context;
        }

        public int Id { get; private set; }

        public async Task<Permission> AddAsync(int id, string name, string description)
        {
            Permission permission = new Permission { Id = id, Name = name, Description = description };
            _context.Permissions.Add(permission);
            await _context.SaveChangesAsync();
            return permission;  
        }


        public async Task DeleteAsync(int id)
        {
            Permission permission = await GetByIdAsync(id);    
            _context.Permissions.Remove(permission);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Permission>> GetAllAsync()
        {
            return await _context.Permissions.ToListAsync();
        }

        public async Task<Permission> GetByIdAsync(int id)
        {
            return _context.Permissions.FirstOrDefault(x => x.Id == id);    
        }

        public async Task<Permission> UpdateAsync(Permission permission)
        {
            var p = await GetByIdAsync(permission.Id);
            permission.Name = p.Name;
            permission.Description = p.Description;
            await _context.SaveChangesAsync();
            return permission;
        }
    }
}
