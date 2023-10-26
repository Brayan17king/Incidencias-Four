using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Persona : BaseEntity
{
    public string NombrePersona { get; set; }
    public string ApellidoPersona { get; set; }
    public int IdGeneroFk { get; set; }
    public Genero Generos { get; set; }
    public int IdCiudadFk { get; set; }
    public Ciudad Ciudades { get; set; }
    public int IdTipoPersonaFk { get; set; }
    public TipoPersona TipoPersonas { get; set; }
    public ICollection<Direccion> Direcciones { get; set; }
    public ICollection<Matricula> Matriculas { get; set; }
    public ICollection<TrainerSalon> TrainerSalones { get; set; }

}