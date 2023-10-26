using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DireccionConfiguration : IEntityTypeConfiguration<Direccion>
    {
        public void Configure(EntityTypeBuilder<Direccion> builder)
        {
            builder.ToTable("Direccion");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasMaxLength(3);
        
            builder.Property(x => x.TipoVia).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Numero).IsRequired().HasColumnType("int");
            builder.Property(x => x.Letra).IsRequired().HasMaxLength(1);
            builder.Property(x => x.SufijoCardinal).IsRequired().HasMaxLength(50);
            builder.Property(x => x.NumViaSecundaria).IsRequired().HasColumnType("int");
            builder.Property(x => x.LetraViaSecundaria).IsRequired().HasMaxLength(2);
            builder.Property(x => x.SufijoCardinalTwo).IsRequired().HasMaxLength(50);

            builder.Property(x => x.IdPersonaFk).HasColumnType("int");
            builder.HasOne(x => x.Personas).WithMany(x => x.Direcciones).HasForeignKey(x => x.IdPersonaFk);
        }
    }
}