using DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityConfig
{
    public class RegionEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<RegionEntity> entityBuilders)
        {
            entityBuilders.ToTable("Region");
            entityBuilders.HasKey(x => x.Id);
            entityBuilders.Property(x => x.Id).IsRequired();
            entityBuilders.Property(b => b.Name).HasColumnName("Nombre");
            entityBuilders.Property(b => b.Description).HasColumnName("Descripcion");

        }
    }
}
