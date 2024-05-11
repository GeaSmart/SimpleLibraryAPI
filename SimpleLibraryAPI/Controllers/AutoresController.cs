using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleLibraryAPI.Entidades;

namespace SimpleLibraryAPI.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AutoresController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<List<Autor>> Get()
        {
            return await context.Autores.AsNoTracking().ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Autor autor)
        {
            var existe = await context.Autores.AnyAsync(x=>x.Nombre == autor.Nombre);
            if (existe)
                return BadRequest($"Ya existe un autor con ese nombre");
            context.Add(autor);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
