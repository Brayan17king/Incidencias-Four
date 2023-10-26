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
    public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamentoRepository
    {
        private readonly IncidenciaContext _context;

        public DepartamentoRepository(IncidenciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Departamento>> GetAllAsync()
        {
            return await _context.Departamentos
            .Include(x => x.Ciudades)
            .ToListAsync();
        }
    }
}