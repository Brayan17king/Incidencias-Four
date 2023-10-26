using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Persistence.Data;

namespace Application.Repositories
{
    public class TipoPersonaRepository : GenericRepository<TipoPersona>
    {
        private readonly IncidenciaContext _context;

        public TipoPersonaRepository(IncidenciaContext context) : base(context)
        {
            _context = context;
        }
    }
}