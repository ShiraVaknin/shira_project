using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shira.Mock;
using Shira.Repositories.Entities;
using Shira.Repositories.Interfaces;
using Shira.Repositories.Repositories;

namespace Shira.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimRepository _claimRepository;
        public ClaimController()
        {
            var mock = new MockContext();
            _claimRepository = new ClaimRepository(mock);
        }
        [HttpGet]
        public List<Claim> Get()
        {
            return _claimRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Claim GetById(int Id)
        {
            return _claimRepository.GetById(Id);
        }
        [HttpPost]
        public void insert(int Id, int RoleId, int PermissionId, EPolicy Policy)
        {
            _claimRepository.Add(Id, RoleId, PermissionId, Policy);
        }
        [HttpPost]
        public void Update(Claim Claim)
        {
            _claimRepository.Update(Claim);
        }
        [HttpDelete]
        public void delete(int Id)
        {
            _claimRepository.Delete(Id);
        }
    }
}

