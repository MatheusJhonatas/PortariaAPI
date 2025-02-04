using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PortariaAPI.Controllers;

[ApiController]
public class PorteiroContoller : ControllerBase
{
    [HttpPost("v1/porteiros")]
    public async Task<IActionResult> Post(
        [FromServices] PortariaDataContext context
    )
    {
        var porteiro = new Porteiro()
        {

            Nome = "Matheus Jhonatas dos Santos",
            DocumentoRG = "50.624.425-8",
            Endereco = "Rua Tabaré 424, apto 56 Torre 1",
            Tipo = "Porteiro"
        };
        await context.Porteiros.AddAsync(porteiro);
        await context.SaveChangesAsync();
        return Created($"v1/porteiros/{porteiro.Id}", porteiro);
    }
}