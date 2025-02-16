using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;


[ApiController]
[Route("api/[controller]")]
public class PorteiroController : ControllerBase
{
    private readonly PortariaDataContext _context;

    public PorteiroController(PortariaDataContext context)
    {
        _context = context;
    }

    [HttpPost("RegistrarEntrada")]
    public async Task<IActionResult> RegistrarEntrada([FromBody] RegistroEntradaDto entradaDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var registro = new Registro
        {
            VisitanteId = entradaDto.VisitanteId,
            MoradorId = entradaDto.MoradorId,
            PrestadorServicoId = entradaDto.PrestadorServicoId,
            HorarioEntrada = DateTime.Now,
            Status = "Entrada"
        };

        _context.Registros.Add(registro);
        await _context.SaveChangesAsync();

        return Ok(registro);
    }

    [HttpPost("RegistrarSaida/{id}")]
    public async Task<IActionResult> RegistrarSaida(int id)
    {
        var registro = await _context.Registros.FindAsync(id);
        if (registro == null)
        {
            return NotFound();
        }

        registro.HorarioSaida = DateTime.Now;
        registro.Status = "Saída";

        _context.Registros.Update(registro);
        await _context.SaveChangesAsync();

        return Ok(registro);
    }
}
public class Registro
{
    public int Id { get; set; }
    public int VisitanteId { get; set; }
    public int MoradorId { get; set; }
    public int PrestadorServicoId { get; set; }
    public DateTime HorarioEntrada { get; set; }
    public DateTime? HorarioSaida { get; set; }
    public string Status { get; set; }
}

public class RegistroEntradaDto
public class RegistroEntradaDto
{
    public int VisitanteId { get; set; }
    public int MoradorId { get; set; }
    public int PrestadorServicoId { get; set; }
}