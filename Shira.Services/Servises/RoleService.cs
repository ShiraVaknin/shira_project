using AutoMapper;
using Shira.Common.DTOs;
using Shira.Repositories.Repositories;
using Shira.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.Services.Servises
{
    public class RoleService : IRoleService
    {
        private readonly RoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public RoleService(RoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
    
        public async Task<RoleDTO> AddAsync(int id, string name, string description)
        {
            return _mapper.Map<RoleDTO>( await _roleRepository.AddAsync(id, name, description));
        }

        public async Task DeleteAsync(int id)
        {
            await _roleRepository.DeleteAsync(id);  
        }

        public List<RoleDTO> GetAll()
        {
            return _mapper.Map<List<RoleDTO>>(_roleRepository.GetAll());   
        }

        public RoleDTO GetById(int id)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.GetById(id));  
        }

        public async Task<RoleDTO> UpdateAsync(RoleDTO role)
        {
            return _mapper.Map<RoleDTO>(await _roleRepository.UpdateAsync(role));

        }
    }
}
