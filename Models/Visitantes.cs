using System.ComponentModel.DataAnnotations;

namespace PortariaAPI.Models;

public class Visitante : IPessoa
{
    public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DocumentoRG { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Tipo { get; set; }
    public string Endereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}