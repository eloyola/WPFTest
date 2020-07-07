using AutoMapper;
using Business.Models;
using FE.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE.Api.Mapper
{
    public class SharedProfile: Profile
    {
        public SharedProfile()
        {
            UserObjects();
        }

        private void UserObjects()
        {
            CreateMap<Region, RegionViewModel>();
            CreateMap<RegionViewModel, Region>();
        }
    }
}
