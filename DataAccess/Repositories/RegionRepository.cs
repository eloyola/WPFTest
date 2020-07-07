using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataAccess.Contracts;
using DataAccess.Contracts.Repositories;
using DataAccess.Contracts.Entities;
using System.Linq.Expressions;

namespace DataAccess.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly ICoworkingDBContext _dbContext;

        public RegionRepository(ICoworkingDBContext coworkingDBContext)
        {
            _dbContext = coworkingDBContext;
        }

        public async Task<IEnumerable<RegionEntity>> GetAll()
        {
            var result = await _dbContext.Regions.ToListAsync();
            return result;
        }

        public async Task<IQueryable<RegionEntity>> Find(Expression<Func<RegionEntity, bool>> expression)
        {
            var result = await Task.Run(() => _dbContext.Regions.Where(expression));
            return result;
        }

        public async Task<RegionEntity> Add(RegionEntity element)
        {
            await _dbContext.Regions.AddAsync(element);
            await _dbContext.SaveChangeAsync();
            return element;
        }

        public async Task Delete(RegionEntity element)
        {
            var result = await Task.Run(() => _dbContext.Regions.Remove(element));
            await _dbContext.SaveChangeAsync();
        }

        //public async Task<IEnumerable<RegionEntity>> GetAll()
        //{
        //    var result = await _coworkingDBContext.Regions.ToListAsync();
        //    return result;
        //}

        //public async Task<RegionEntity> Update(int id, RegionEntity element)
        //{
        //    var entity = await Get(id);
        //    entity.Name = element.Name;
        //    _coworkingDBContext.Regions.Update(entity);
        //    await _coworkingDBContext.SaveChangeAsync();
        //    return entity;
        //}

        //public async Task<RegionEntity> Update(RegionEntity entity)
        //{
        //    var updateEntity = _coworkingDBContext.Regions.Update(entity);
        //    await _coworkingDBContext.SaveChangeAsync();
        //    return updateEntity.Entity;
        //}
    }
}
