using Shira.Repositories.Entities;
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
        List<Claim> GetAll();

        Claim GetById(int id);

        Claim Add(int id, int RoleId, int PermissionId, EPolicy policy);

        Claim Update(Claim claim);

        void Delete(int id);   
        
    }
}
