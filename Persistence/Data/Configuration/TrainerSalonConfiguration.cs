using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TrainerSalonConfiguration : IEntityTypeConfiguration<TrainerSalon>
    {
        public void Configure(EntityTypeBuilder<TrainerSalon> builder)
        {
            builder.ToTable("TrainerSalon");

            builder.HasKey(xx => new {xx.IdPersonaFk, xx.IdSalonFk});

            builder.Property(xx => xx.IdPersonaFk).HasColumnType("int");
            builder.HasOne(xx => xx.Personas).WithMany(x => x.TrainerSalones).HasForeignKey(xx => xx.IdPersonaFk);

            builder.Property(xx => xx.IdSalonFk).HasColumnType("int");
            builder.HasOne(xx => xx.Salones).WithMany(x => x.TrainerSalones).HasForeignKey(xx => xx.IdSalonFk);

        }
    }
}