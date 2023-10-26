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
    public class GeneroRepository : GenericRepository<Genero>, IGeneroRepository
    {
        private readonly IncidenciaContext _context;

        public GeneroRepository(IncidenciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Genero>> GetAllAsync()
        {
            return await _context.Generos
            .Include(x => x.Personas)
            .ToListAsync();
        }
    }
}