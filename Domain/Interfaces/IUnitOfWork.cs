using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public ICiudadRepository Ciudades { get;}
        public IDepartamentoRepository Departamentos { get;}
        public IDireccionRepository Direcciones { get;}
        public IGeneroRepository Generos { get;}
        public IMatriculaRepository Matriculas { get;}
        public IPaisRepository Paises { get;}
        public IPersonaRepository Personas { get;}
        public ISalonRepository Salones { get;}
        public ITipoPersonaRepository TipoPersonas { get;}
        Task<int> SaveAsync();
    }
}