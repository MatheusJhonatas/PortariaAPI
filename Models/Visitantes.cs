namespace PortariaAPI.Models;

public class Visitante
{
    public string Nome { get; set; }
    public string DocumentoRG { get; set; }
    public string Tipo { get; set; }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
    }
}