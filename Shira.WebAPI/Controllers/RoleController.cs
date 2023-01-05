using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shira.Common.DTOs;
using Shira.Mock;
using Shira.Services.Interfaces;

namespace Shira.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<List<RoleDTO>> Get()
        {
            return await _roleService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<RoleDTO> GetById(int id)
        {
            return await _roleService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task insert(int id, string name, string description)
        {
            await _roleService.AddAsync(id, name, description);
        }

        [HttpPost]
        public async Task Update(RoleDTO role)
        {
            await _roleService.UpdateAsync(role);
        }

        [HttpDelete]
        public async Task delete(int id)
        {
            await _roleService.DeleteAsync(id);
        }
    }
}
