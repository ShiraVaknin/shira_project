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
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionServise;
        public PermissionController(IPermissionService permissionServise)
        {
            _permissionServise = permissionServise;
        }

        [HttpGet]
        public List<PermissionDTO> Get()
        {
            return _permissionServise.GetAll();
        }

        [HttpGet("{id}")]
        public PermissionDTO GetById(int id)
        {
            return _permissionServise.GetById(id);
        }

        [HttpPost]
        public void insert(int id, string name, string description)
        {
            _permissionServise.AddAsync(id, name, description);
        }

        [HttpPost]
        public void Update(PermissionDTO permission)
        {
            _permissionServise.UpdateAsync(permission);
        }

        [HttpDelete]
        public void delete(int id)
        {
            _permissionServise.DeleteAsync(id);
        }
    }
}
