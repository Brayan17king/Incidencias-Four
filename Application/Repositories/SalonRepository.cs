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
    public class SalonRepository : GenericRepository<Salon>, ISalonRepository
    {
        private readonly IncidenciaContext _context;

        public SalonRepository(IncidenciaContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Salon>> GetAllAsync()
        {
            return await _context.Salones
            .Include(x => x.Matriculas)
            .Include(x => x.TrainerSalones)
            .ToListAsync();
        }
    }
}