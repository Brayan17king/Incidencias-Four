using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IncidenciaContext _context;
        private IPaisRepository _Paises;
        private ICiudadRepository _Ciudades;
        private IDepartamentoRepository _Departamentos;
        private IDireccionRepository _Direcciones;
        private IGeneroRepository _Generos;
        private IMatriculaRepository _Matriculas;
        private IPersonaRepository _Personas;
        private ISalonRepository _Salones;
        private ITipoPersonaRepository _TipoPersonas;

        public UnitOfWork(IncidenciaContext context)
        {
            _context = context;
        }
        public ICiudadRepository Ciudades
        {
            get
            {
                if (_Ciudades == null)
                {
                    _Ciudades = new CiudadRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Ciudades;
            }
        }

        public IDepartamentoRepository Departamentos
        {
            get
            {
                if (_Departamentos == null)
                {
                    _Departamentos = new DepartamentoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Departamentos;
            }
        }

        public IDireccionRepository Direcciones
        {
            get
            {
                if (_Direcciones == null)
                {
                    _Direcciones = new DireccionRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Direcciones;
            }
        }

        public IGeneroRepository Generos
        {
            get
            {
                if (_Generos == null)
                {
                    _Generos = new GeneroRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Generos;
            }
        }

        public IMatriculaRepository Matriculas
        {
            get
            {
                if (_Matriculas == null)
                {
                    _Matriculas = new MatriculaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Matriculas;
            }
        }

        public IPaisRepository Paises
        {
            get
            {
                if (_Paises == null)
                {
                    _Paises = new PaisRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Paises;
            }
        }

        public IPersonaRepository Personas
        {
            get
            {
                if (_Personas == null)
                {
                    _Personas = new PersonaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Personas;
            }
        }

        public ISalonRepository Salones
        {
            get
            {
                if (_Salones == null)
                {
                    _Salones = new SalonRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Salones;
            }
        }
        public ITipoPersonaRepository TipoPersonas
        {
            get
            {
                if (_TipoPersonas == null)
                {
                    _TipoPersonas = new TipoPersonaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _TipoPersonas;
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}