using System.ComponentModel.DataAnnotations.Schema;
using PortariaAPI.Models;

public class Registro
{
    public int Numero { get; set; }
    public int VisitanteId { get; set; }

    public Visitante visitante { get; set; }

    public int MoradorId { get; set; }
    public Morador morador { get; set; }
    public int PrestadorServicoId { get; set; }
    public PrestadorServico prestadorServico { get; set; }
    public DateTime? horarioEntrada { get; set; }
    public DateTime? horarioSaida { get; set; }
    public string Status { get; set; }


}