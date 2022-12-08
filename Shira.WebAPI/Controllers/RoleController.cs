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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public List<RoleDTO> Get()
        {
            return _roleService.GetAll();
        }

        [HttpGet("{id}")]
        public RoleDTO GetById(int id)
        {
            return _roleService.GetById(id);
        }

        [HttpPost]
        public void insert(int id, string name, string description)
        {
            _roleService.AddAsync(id, name, description);
        }

        [HttpPost]
        public void Update(RoleDTO role)
        {
            _roleService.UpdateAsync(role);
        }

        [HttpDelete]
        public void delete(int id)
        {
            _roleService.DeleteAsync(id);
        }
    }
}
