using PortariaAPI.Models;

public class Registro
{
    public int Numero { get; set; }
    public Visitante visitante { get; set; }
    public DateTime horarioEntrada { get; set; }
    public DateTime horarioSaida { get; set; }
    public string Status { get; set; }
    public void RegistrarEntrada(Visitante visitante, DateTime horario)
    {

    }
    public void RegistrarSaida(Visitante visitante, DateTime horario)
    {

    }

}