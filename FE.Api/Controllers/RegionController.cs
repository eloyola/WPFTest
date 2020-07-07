using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Models;
using FE.Api.Model;
using FE.Application.Contracts.ContractServices;
using Microsoft.AspNetCore.Mvc;

namespace FE.Api.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _regionService;
        private readonly IMapper _mapper;

        public RegionController(IRegionService userService, IMapper mapper)
        {
            _regionService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        [Produces("application/json", Type = typeof(IEnumerable<RegionViewModel>))]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<RegionViewModel> result = null;
            //var redisConnect = ConnectionMultiplexer.Connect(_appConfig.DbConfig.RedisCn);
            //IDatabase Rediscache = redisConnect.GetDatabase();
            //var redisValue = Rediscache.StringGetAsync("stateDetails-User");

            //if (string.IsNullOrEmpty(redisValue.Result))
            //{
                var serviceResult = await _regionService.GetAll();
                result = _mapper.Map<IEnumerable<RegionViewModel>>(serviceResult);
                //await Rediscache.StringSetAsync("stateDetails-User", JsonConvert.SerializeObject(result), TimeSpan.FromMinutes(5));
            //}
            //else
            //{
            //    result = JsonConvert.DeserializeObject<IEnumerable<UserViewModel>>(redisValue.Result);
            //}

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json", Type = typeof(RegionViewModel))]
        public async Task<IActionResult> AddAdmin([FromBody] RegionViewModel admin)
        {
            var p = await _regionService.Add(_mapper.Map<Region>(admin));
            return Ok(p);
        }
    }
}
