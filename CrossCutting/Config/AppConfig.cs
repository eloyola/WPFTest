using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace CrossCutting.Config
{
    public class AppConfig : IAppConfig
    {
        private readonly IConfiguration _configuration;

        public AppConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string ServiceUrl => _configuration.GetSection("ServiceUrl:Url").Value;

        //public Dbconfig DbConfig => new Dbconfig
        //{
        //    Host = _configuration.GetSection("DbConfig:Host").Value,
        //    Key = _configuration.GetSection("DbConfig:Key").Value,
        //    Db = _configuration.GetSection("DbConfig:Db").Value,
        //    RedisIsEnabled = Convert.ToBoolean(_configuration.GetSection("RedisConfig:Enabled").Value),
        //    RedisCn = _configuration.GetSection("RedisConfig:Cn").Value
        //};
    }
}
