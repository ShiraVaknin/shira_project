using Microsoft.EntityFrameworkCore;
using Shira.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.Repositories.Interfaces
{
    public interface IContext
    {
        public DbSet <Role> Roles { get; set; }

        public DbSet<Permission> Permissions { get; set; }  

        public DbSet<Claim> Claims { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

    }
}
