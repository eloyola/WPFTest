using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FE.Application.Contracts.ContractServices
{
    public interface IRegionService
    {
        Task<IEnumerable<Region>> GetAll();

        Task<Region> Add(Region element);

        Task<Region> Find(int id);

        Task Delete(int id);
    }
}
