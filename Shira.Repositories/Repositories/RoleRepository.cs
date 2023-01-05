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
    public class RoleRepository : IRoleRepository
    {
        private readonly IContext _context;

        public RoleRepository(IContext context)
        {
            _context = context;
        }

        public async Task<List <Role>> GetAllAsync() 
        { 
            return await _context.Roles.ToListAsync();  
        }

        public async Task<Role> GetByIdAsync(int id)
        {
            return await _context.Roles.FindAsync(id);
        }

        public async Task<Role> AddAsync(int id, string name, string description)
        {
            Role role = new Role { Id = id, Name = name, Description = description };    
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();  
            return role;    
        }

        public async Task<Role> UpdateAsync(Role role)
        {
            var r = GetById(role.Id);
            role.Name = r.Name;
            role.Description = r.Description;
            await _context.SaveChangesAsync();
            return role;
        }

        public async Task DeleteAsync(int id)
        {
            Role role = GetById(id);
            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
        }


    }


}
