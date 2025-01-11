using PortariaAPI.Interface;
using PortariaAPI.Models;

public class Portaria
{
    public List<Registro> Registros { get; set; }
    public List<FuncionarioPortaria> FuncionariosPortarias { get; set; }
    // public void adicionarFuncionario(FuncionarioPortaria funcionario)
    // {

    // }
    // public Registro obterRegistroPorNumero(int numero)
    // {
    //     return Registros.FirstOrDefault(r => r.Numero == numero);
    // }

    // public void RegistrarEntrada(int idPessoa, DateTime dataHoraEntrada)
    // {
    //     throw new NotImplementedException();
    // }

    // public void RegistrarSaida(int idPessoa, DateTime dataHoraSaida)
    // {
    //     throw new NotImplementedException();
    // }
}