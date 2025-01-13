using PortariaAPI.Interface;
using PortariaAPI.Models;

public class Porteiro : IPessoa
{
    public List<Registro> Registros { get; set; }

    public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DocumentoRG { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Endereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Tipo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}