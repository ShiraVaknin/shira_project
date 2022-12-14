using AutoMapper;
using Shira.Common.DTOs;
using Shira.Repositories.Entities;
using Shira.Repositories.Interfaces;
using Shira.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shira.Services.Servises
{
    public class ClaimServise : IClaimService
    {
        private readonly IClaimRepository _claimRepository;
        private readonly IMapper _mapper;

        public ClaimServise(IClaimRepository claimRepository, IMapper mapper)
        {
            _claimRepository = claimRepository;
            _mapper = mapper;
        }   

        public async Task<ClaimDTO> AddAsync(int id, int roleId, int permissionId, EPolicy policy)
        {
            return _mapper.Map<ClaimDTO>( await _claimRepository.AddAsync(id, roleId, permissionId,policy));
        }

        public async Task DeleteAsync(int id)
        {
            await _claimRepository.DeleteAsync(id);
        }

        public async Task<List<ClaimDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ClaimDTO>>(await _claimRepository.GetAllAsync());
        }

        public async Task<ClaimDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ClaimDTO>(await _claimRepository.GetByIdAsync(id));   
        }

        public async Task<ClaimDTO> UpdateAsync(ClaimDTO claim)
        {
            return _mapper.Map<ClaimDTO>( await _claimRepository.UpdateAsync(_mapper.Map<Claim>(claim)));
        }
    }
}
