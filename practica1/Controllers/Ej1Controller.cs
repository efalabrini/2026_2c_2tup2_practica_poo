using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SaludoController : ControllerBase
{
    [HttpPost("saludar")]
    public IActionResult Saludar([FromBody] List<Persona> personas)
    {
        if (personas == null || personas.Count != 3)
        {
            return BadRequest("Debes enviar exactamente una lista con 3 personas.");
        }

        List<string> saludos = personas
            .Select(p => p.GetSaludo())
            .ToList();

        return Ok(saludos);
    }
}