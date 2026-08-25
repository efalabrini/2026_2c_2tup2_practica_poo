using Microsoft.AspNetCore.Mvc;
using practica1.Ej3;

namespace practica1.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    [HttpGet("Persona")]
    public string CrearPersona([FromQuery] string nombre)
    {
        var persona = new Persona { Nombre = nombre };
        return persona.Saludar();
    }

    [HttpGet("Estudiante")]
    public List<string> CrearEstudiante([FromQuery] string nombre, [FromQuery] int edad)
    {
        var estudiante = new Estudiante { Nombre = nombre };
        estudiante.SetEdad(edad);

        return new List<string>
        {
            estudiante.Saludar(),
            estudiante.MostrarEdad(),
            estudiante.Estudiar()
        };
    }

    [HttpGet("Profesor")]
    public List<string> CrearProfesor([FromQuery] string nombre, [FromQuery] int edad)
    {
        var profesor = new Profesor { Nombre = nombre };
        profesor.SetEdad(edad);

        return new List<string>
        {
            profesor.Saludar(),
            profesor.Explicar()
        };
    }
}