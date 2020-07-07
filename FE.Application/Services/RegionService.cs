using AutoMapper;
using Business.Models;
using DataAccess.Contracts.Entities;
using DataAccess.Contracts.Repositories;
using FE.Application.Contracts.ContractServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE.Application.Services
{
    public class RegionService : IRegionService
    {
        private readonly IRegionRepository _repository;
        private readonly IMapper _mapper;

        public RegionService(IRegionRepository adminRepository, IMapper mapper)
        {
            _repository = adminRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Region>> GetAll()
        {
            List<Region> result;
            var admins = await _repository.GetAll();
            try
            {
                result = admins.Select(p => _mapper.Map<Region>(p)).ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public async Task<Region> Add(Region element)
        {
            var repoResult = await _repository.Add(_mapper.Map<RegionEntity>(element));
            return _mapper.Map<Region>(repoResult);
        }

        public async Task<Region> Find(int id)
        {
            var repoResult = await _repository.Find(p => p.Id == id);
            var u = repoResult.SingleOrDefault();
            return _mapper.Map<Region>(u);
        }

        public async Task Delete(int id)
        {
            var repoResult = await _repository.Find(p => p.Id == id);
            var u = repoResult.SingleOrDefault();
            if (u != null)
            {
                await _repository.Delete(u);
            }
        }

        public Task<Region> Find(string userName)
        {
            throw new NotImplementedException();
        }

        //public async Task<Region> UpdateAdmin(Region admin)
        //{
        //    var updated = await _repository.Update(AdminMapper.Map(admin));
        //    return AdminMapper.Map(updated);
        //}
    }
}
