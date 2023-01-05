using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shira.Common.DTOs;
using Shira.Mock;
using Shira.Services.Interfaces;

namespace Shira.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionServise;
        public PermissionController(IPermissionService permissionServise)
        {
             _permissionServise = permissionServise;
        }

        [HttpGet]
        public async Task<List<PermissionDTO>> Get()
        {
            return await _permissionServise.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<PermissionDTO> GetById(int id)
        {
            return await _permissionServise.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task insert(int id, string name, string description)
        {
            await _permissionServise.AddAsync(id, name, description);
        }

        [HttpPost]
        public async void Update(PermissionDTO permission)
        {
            await _permissionServise.UpdateAsync(permission);
        }

        [HttpDelete]
        public async Task delete(int id)
        {
            await _permissionServise.DeleteAsync(id);
        }
    }
}
