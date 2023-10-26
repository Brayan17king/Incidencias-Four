using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class IncidenciaContext : DbContext
    {
        public IncidenciaContext(DbContextOptions<IncidenciaContext> options) : base(options)
        {
        }

        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Salon> Salones { get; set; }
        public DbSet<TipoPersona> TipoPersonas { get; set; }
        public DbSet<TrainerSalon> TrainerSalones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}