using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortariaAPI.Models;

public class Visitante : IPessoa
{
    public string Nome { get; set; }
    public string DocumentoRG { get; set; }
    public string Tipo { get; set; }
    public ICollection<Registro> Registros { get; set; }
    public int Id { get; set; }
    public string Rua { get; set; }
    public string NumeroCasa { get; set; }
}