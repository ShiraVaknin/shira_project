using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shira.Common.DTOs;
using Shira.Mock;
using Shira.Repositories.Repositories;
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
        public List<ClaimDTO> Get()
        {
            return _claimServise.GetAll();
        }

        [HttpGet("{id}")]
        public ClaimDTO GetById(int id)
        {
            return _claimServise.GetById(id);
        }

        [HttpPost]
        public void insert(int id, int roleId, int permissionId, ClaimDTO.EPolicy policy)
        {
            _claimServise.AddAsync(id, roleId, permissionId, policy);
        }

        [HttpPost]
        public void Update(ClaimDTO claim)
        {
            _claimServise.UpdateAsync(claim);
        }

        [HttpDelete]
        public void delete(int id)
        {
            _claimServise.DeleteAsync(id);
        }
    }
}

