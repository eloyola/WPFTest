using DataAccess.Contracts.Repositories;
using DataAccess.Repositories;
using FE.Application.Contracts.ContractServices;
using FE.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FE.Application.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterServices(services);
            AddRegisterRepositories(services);
            //AddRegisterOther(services);
            return services;
        }

        public static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IRegionService, RegionService>();
            return services;
        }
        public static IServiceCollection AddRegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRegionRepository, RegionRepository>();
            //services.AddTransient<IBookingRepository, BookingRepository>();
            //services.AddTransient<IOfficeRepository, OfficeRepository>();
            //services.AddTransient<IRoomRepository, RoomRepository>();
            //services.AddTransient<IServiceRepository, ServiceRepository>();
            //services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }
    }
}
