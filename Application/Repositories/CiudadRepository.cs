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
    public class CiudadRepository : GenericRepository<Ciudad>, ICiudadRepository
    {
        private readonly IncidenciaContext _context;

        public CiudadRepository(IncidenciaContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Ciudad>> GetAllAsync()
        {
            return await _context.Ciudades
            .Include(x => x.Personas)
            .ToListAsync();
        }
    }
}