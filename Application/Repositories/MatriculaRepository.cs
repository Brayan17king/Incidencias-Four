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
    public class MatriculaRepository : GenericRepository<Matricula>, IMatriculaRepository
    {
        private readonly IncidenciaContext _context;

        public MatriculaRepository(IncidenciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Matricula>> GetAllAsync()
        {
            return await _context.Matriculas
            .ToListAsync();
        }
    }
}