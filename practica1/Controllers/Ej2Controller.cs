using Microsoft.AspNetCore.Mvc;
using practica1.Ej2;

namespace practica1.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej2Controller : ControllerBase
{
    private static List<PhotoBook> albums = new List<PhotoBook>();

    private static int nextId = 1;

    [HttpPost("standard")]
    public PhotoBook CreateAlbum(int? pages)
    {
        PhotoBook album;

        if (pages.HasValue)
        {
            album = new PhotoBook(pages.Value);
        }
        else
        {
            album = new PhotoBook();
        }

        album.Id = nextId;
        nextId++;

        albums.Add(album);

        return album;
    }

    [HttpPost("big")]
    public PhotoBook CreateBigAlbum()
    {
        BigPhotoBook album = new BigPhotoBook();

        album.Id = nextId;
        nextId++;

        albums.Add(album);

        return album;
    }

    [HttpGet("{id:int}/pages")]
    public ActionResult<int> GetNumberPages([FromRoute] int id)
    {
        PhotoBook? album = albums.FirstOrDefault(a => a.Id == id);

        if (album == null)
        {
            return NotFound();
        }

        return Ok(album.GetNumberPages());
    }

    [HttpGet]
    public IActionResult GetAlbums()
    {
        var resultado = albums.Select(album => new
        {
            album.Id,
            NumberPages = album.GetNumberPages()
        });

        return Ok(resultado);
    }
      }
