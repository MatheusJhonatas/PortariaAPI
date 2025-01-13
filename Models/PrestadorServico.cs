using PortariaAPI.Models;


public class PrestadorServico : IPessoa
{
    public string empresa { get; set; }

    public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DocumentoRG { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Endereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Tipo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}