using PortariaAPI.Models;

public class Morador : IPessoa
{
    public ICollection<Registro> Registros { get; set; }
    public string Endereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DocumentoRG { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Tipo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}