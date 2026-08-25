using Microsoft.AspNetCore.Mvc;
using practica1.Controllers.Ej2;

namespace practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej2Controller : ControllerBase
    {
        private static List<PhotoBook> albums = new List<PhotoBook>();

        private static int nextId = 1;

        // Crear álbum estándar
        [HttpPost("standard")]
        public ActionResult<PhotoBook> CreateStandardAlbum(int? numPages)
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

            albums.Add(album);

            return Ok(album);
        }
        [HttpPost("big")]
        public ActionResult<PhotoBook> CreateBigAlbum()
        {
            BigPhotoBook album = new BigPhotoBook();

            album.Id = nextId++;

            albums.Add(album);

            return Ok(album);
        }

        [HttpGet("{id}/pages")]
        public ActionResult<int> GetNumberPages(int id)
        {
            PhotoBook? album = albums.FirstOrDefault(a => a.Id == id);

            if (album == null)
            {
                return NotFound("No existe un álbum con ese ID.");
            }

            return Ok(album.GetNumberPages());
        }

        [HttpGet]
        public ActionResult<List<PhotoBook>> GetAllAlbums()
        {
            return Ok(albums);
        }
    }
}