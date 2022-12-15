using AutoMapper;
using Shira.Common.DTOs;
using Shira.Repositories.Interfaces;
using Shira.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.Services.Servises
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;

        public PermissionService(IPermissionRepository permissionRepository, IMapper mapper)
        {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }   

        public async Task<PermissionDTO> AddAsync(int id, string name, string decraption)
        {
            return _mapper.Map<PermissionDTO>( await _permissionRepository.AddAsync(id, name, decraption)); 
        }

        public async Task DeleteAsync(int id)
        {
            await _permissionRepository.DeleteAsync(id);
        }

        public List<PermissionDTO> GetAll()
        {
            return _mapper.Map<List<PermissionDTO>>( _permissionRepository.GetAll()); 
        }

        public PermissionDTO GetById(int id)
        {
            return _mapper.Map<PermissionDTO>(_permissionRepository.GetById(id));
        }

        public async Task<PermissionDTO> UpdateAsync(PermissionDTO permissionole)
        {
            return _mapper.Map<PermissionDTO>( await _permissionRepository.UpdateAsync(permissionole));   
        }
    }
}
