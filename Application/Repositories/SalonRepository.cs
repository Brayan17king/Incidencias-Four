using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
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
    }
}