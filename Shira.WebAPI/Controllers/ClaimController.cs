using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shira.Common.DTOs;
using Shira.Mock;
using Shira.Services.Interfaces;

namespace Shira.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimService _claimServise;

        public ClaimController(IClaimService claimServise)
        {
            _claimServise = claimServise;
        }

        [HttpGet]
        public async Task<List<ClaimDTO>> Get()
        {
            return await _claimServise.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ClaimDTO> GetById(int id)
        {
            return await _claimServise.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task insert(int id, int roleId, int permissionId, Shira.Repositories.Entities.EPolicy policy)
        {
            await _claimServise.AddAsync(id, roleId, permissionId, policy);
        }

        [HttpPost]
        public async Task Update(ClaimDTO claim)
        {
            await _claimServise.UpdateAsync(claim);
        }

        [HttpDelete]
        public async Task delete(int id)
        {
             await _claimServise.DeleteAsync(id);
        }
    }
}

