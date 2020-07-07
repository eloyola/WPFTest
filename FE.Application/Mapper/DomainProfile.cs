using AutoMapper;
using Business.Models;
using DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FE.Application.Mapper
{
    public class DomainProfile: Profile
    {
        public DomainProfile()
        {
            RegionObjects();
        }

        private void RegionObjects()
        {
            CreateMap<RegionEntity, Region>();
            CreateMap<Region, RegionEntity>();
        }
    }
}
