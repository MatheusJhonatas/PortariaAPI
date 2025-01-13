using PortariaAPI.Models;

public class Morador : IPessoa
{
    public List<Registro> Autorizacoes { get; set; } = new List<Registro>();
    public string Endereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DocumentoRG { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Tipo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}