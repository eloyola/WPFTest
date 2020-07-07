using DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts.Repositories
{
    public interface IRegionRepository : IRepository<RegionEntity>
    {
        //Task<RegionEntity> Get(int id);

        //Task DeleteAsync(int id);

        //Task<RegionEntity> Update(int id, RegionEntity element);
    }
}
