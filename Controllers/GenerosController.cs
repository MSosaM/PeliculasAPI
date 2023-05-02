using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PeliculasAPI.Entidades;
using PeliculasAPI.Filtros;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GenerosController: ControllerBase
    {
        private readonly ILogger<GenerosController> logger;

        public GenerosController(ILogger<GenerosController> logger)
        {
            this.logger = logger;
        }

        [HttpGet] // api/generos
        public ActionResult<List<Genero>> Get()
        {
            return new List<Genero>() { new Genero() { Id = 1, Nombre = "Comedia" } };
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Genero>> Get(int Id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Genero genero)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Genero genero)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
