using Microsoft.AspNetCore.Mvc;
using practica1.Ej4;

namespace practica1.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{
    [HttpGet("ConducirDirecto")]
    public string ConducirDirecto([FromQuery] int combustible)
    {
        var coche = new Coche(combustible);
        return coche.Conducir();
    }

    [HttpGet("CargarYConducir")]
    public string CargarYConducir([FromQuery] int cantidadACargar)
    {
        var coche = new Coche(0);
        coche.CargarCombustible(cantidadACargar);
        return coche.Conducir();
    }
}