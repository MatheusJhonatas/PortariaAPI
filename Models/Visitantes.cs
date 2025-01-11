using System.ComponentModel.DataAnnotations;

namespace PortariaAPI.Models;

public class Visitante
{
    [Required]
    public string Nome { get; set; }
    [Required]
    public string DocumentoRG { get; set; }
    public string Tipo { get; set; }
    // public void ExibirDetalhes()
    // {
    //     Console.WriteLine($"Nome: {Nome}");
    // }
}