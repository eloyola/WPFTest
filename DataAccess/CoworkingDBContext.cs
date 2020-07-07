using DataAccess.Contracts;
using DataAccess.Contracts.Entities;
using DataAccess.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CoworkingDBContext: DbContext, ICoworkingDBContext
    {
        public DbSet<RegionEntity> Regions { get; set; }

        public CoworkingDBContext(DbContextOptions options) : base(options)
        {

        }

        public CoworkingDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RegionEntityConfig.SetEntityBuilder(modelBuilder.Entity<RegionEntity>());

            base.OnModelCreating(modelBuilder);
        }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
