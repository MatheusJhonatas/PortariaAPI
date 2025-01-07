namespace PortariaAPI.Interface
{
    public interface IRegistroOperacoes
    {
        void RegistrarEntrada(int idPessoa, DateTime dataHoraEntrada);
        void RegistrarSaida(int idPessoa, DateTime dataHoraSaida);
    }
}