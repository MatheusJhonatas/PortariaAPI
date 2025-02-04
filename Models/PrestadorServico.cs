using System.ComponentModel.DataAnnotations.Schema;
using PortariaAPI.Models;


public class PrestadorServico : IPessoa
{
    public string Rua { get; set; }
    public string NumeroCasa { get; set; }
    public string empresa { get; set; }
    public string Nome { get; set; }
    public string DocumentoRG { get; set; }
    public string Tipo { get; set; }
    public int Id { get; set; }
    public ICollection<Registro> Registros { get; set; }
}