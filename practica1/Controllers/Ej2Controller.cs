using Microsoft.AspNetCore.Mvc;
using practica1.Ej2;

namespace practica1.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej2Controller : ControllerBase
{
    private static List<PhotoBook> albumes = new List<PhotoBook>();
    private static int nextId = 1;

    [HttpPost("Estandar")]
    public PhotoBook CrearEstandar([FromQuery] int? numPages)
    {
        PhotoBook album;

        if (numPages.HasValue)
        {
            album = new PhotoBook(numPages.Value);
        }
        else
        {
            album = new PhotoBook();
        }

        album.Id = nextId++;
        albumes.Add(album);

        return album;
    }

    [HttpPost("Grande")]
    public PhotoBook CrearGrande()
    {
        var album = new BigPhotoBook();
        album.Id = nextId++;
        albumes.Add(album);

        return album;
    }

    [HttpGet("Consultar/{id}")]
    public ActionResult<int> ConsultarPaginas(int id)
    {
        var album = albumes.FirstOrDefault(a => a.Id == id);

        if (album == null)
        {
            return NotFound("Álbum no encontrado.");
        }

        return album.GetNumberPages();
    }

    [HttpGet]
    public List<PhotoBook> ObtenerTodos()
    {
        return albumes;
    }
}