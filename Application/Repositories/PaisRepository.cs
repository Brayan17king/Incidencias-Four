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
    public class PaisRepository : GenericRepository<Pais>, IPaisRepository
    {
        private readonly IncidenciaContext _context;

        public PaisRepository(IncidenciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Pais>> GetAllAsync()
        {
            return await _context.Paises
            .Include(x => x.Departamentos)
            .ToListAsync();
        }
    }
}