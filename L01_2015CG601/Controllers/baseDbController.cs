using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2015CG601.Models;
using Microsoft.EntityFrameworkCore;
namespace L01_2015CG601.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class baseDbController : ControllerBase
    {
        private readonly baseDbContext _baseDbContext;

        public baseDbController(baseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<baseDb> listadoEquipo = (from usuarios in _baseDbContext.baseDb
                                           select usuarios ).ToList();
            
            if (listadoEquipo.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoEquipo);
        }
        

        [HttpGet]
        [Route("Find/{filtro}")]
        public IActionResult FindByDescription(string filtro)
        {
            baseDb usuarios = (from e in _baseDbContext.baseDb  
                               where e.nombre.Contains(filtro)
                               select e).FirstOrDefault();
            if (usuarios == null)
            {
                return NotFound();

            }
            return Ok(usuarios);
        }


    }
}

