using DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface ICoworkingDBContext
    {
        DbSet<RegionEntity> Regions { get; set; }
        //DbSet<AdminEntity> Admins { get; set; }
        //DbSet<BookingEntity> Bookings { get; set; }
        //DbSet<OfficeEntity> Offices { get; set; }
        //DbSet<OfficeRoomEntity> OfficeRooms { get; set; }
        //DbSet<RoomServiceEntity> RoomServices { get; set; }
        //DbSet<RoomEntity> Rooms { get; set; }
        //DbSet<ServiceEntity> Services { get; set; }

        //DbSet<TEntity> Set<TEntity>() where TEntity : class;
        //DatabaseFacade Database { get; }
        //Task<int> SaveChangeAsync(CancellationToken cancellationToken = default(CancellationToken));
        //void RemoveRange(IEnumerable<object> entities);
        //EntityEntry Update(object entity);

        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
