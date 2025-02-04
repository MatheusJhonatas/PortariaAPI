using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PortariaAPI.Controllers;

[ApiController]
public class PorteiroContoller : ControllerBase
{
    [HttpPost("v1/porteiros")]
    public async Task<IActionResult> Post(
        [FromServices] PortariaDataContext context,
        [FromBody] Porteiro model
    )
    {
        var porteiro = new Porteiro()
        {
            Id = 1,
            Nome = model.Nome,
            DocumentoRG = model.DocumentoRG,
            Rua = model.Rua,
            NumeroCasa = model.NumeroCasa,
            Tipo = model.Tipo
        };
        await context.Porteiros.AddAsync(porteiro);
        await context.SaveChangesAsync();
        return Created($"v1/porteiros/{porteiro.Id}", porteiro);
    }
}