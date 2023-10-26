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
    public class PersonaRepository : GenericRepository<Persona>, IPersonaRepository
    {
        private readonly IncidenciaContext _context;

        public PersonaRepository(IncidenciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Persona>> GetAllAsync()
        {
            return await _context.Personas
            .Include(x => x.Direcciones)
            .Include(x => x.Matriculas)
            .Include(x => x.TrainerSalones)
            .ToListAsync();
        }
    }
}