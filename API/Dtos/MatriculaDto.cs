using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
public class MatriculaDto
{
    public int Id { get; set; }
    public int IdPersonaFk { get; set; }
    public int IdSalonFk { get;}
}
