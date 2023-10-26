using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repositories
{
    public class DireccionRepository : GenericRepository<Direccion>, IDireccionRepository
    {
        private readonly IncidenciaContext _context;

        public DireccionRepository(IncidenciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Direccion>> GetAllAsync()
        {
            return await _context.Direcciones
            .ToListAsync();
        }
    }
}