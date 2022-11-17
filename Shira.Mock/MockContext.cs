using Shira.Repositories.Entities;
using Shira.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.Mock
{
    public class MockContext: IContext
    {
        public List<Role> Roles { get; set; }

        public List<Permission> Permissions { get; set; }

        public List<Claim> Claims { get; set; }

        public MockContext()
        {
            Claims = new List<Claim>();
            Roles = new List<Role>();
            Permissions = new List<Permission>();

            Roles.Add(new Role { Id = 1, Name = "admin", Description = "full access" });
            Roles.Add(new Role { Id = 2, Name = "student", Description = "student in seminary" });

            Permissions.Add(new Permission { Id = 1, Name = "ViewAllTests", Description = "" });

            Claims.Add(new Claim { Id = 1, RoleId = 1, PermissionId = 1, Policy = EPolicy.Allow });
            Claims.Add(new Claim { Id = 2, RoleId = 2, PermissionId = 1, Policy = EPolicy.Deny });
        }

        
    }
}
