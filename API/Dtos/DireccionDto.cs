using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
public class DireccionDto
{
    public int Id { get; set; }
    public string TipoVia { get; set; }
    public int Numero { get; set; }
    public string Letra { get; set; }
    public string SufijoCardinal { get; set; }
    public int NumViaSecundaria { get; set; }
    public string LetraViaSecundaria { get; set; }
    public string SufijoCardinalTwo { get; set; }
    public int IdPersonaFk { get; set; }
}
