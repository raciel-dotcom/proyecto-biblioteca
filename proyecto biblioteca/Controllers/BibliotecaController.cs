using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_biblioteca.DataBase;
using proyecto_biblioteca.DataBase.Modelos;

namespace proyecto_biblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliotecaController : ControllerBase
    {
        private readonly ILogger<BibliotecaController> _logger;
        private readonly AppDbContex _Context;

        public BibliotecaController(ILogger<BibliotecaController> logger, AppDbContex Context)
        {
            _logger = logger;
            _Context = Context;
        }
        [HttpGet(Name = "GetBooks")]
        public async Task<ActionResult<IEnumerable<Book>>> Get()

        {
            _logger.LogInformation("Inicia Solicitud GET Books");
            var Result = await _Context.Book.ToListAsync();


            return Ok(Result);
        }

        [HttpPost(Name = "AddBok")]
        public IActionResult Post()
        {
            _logger.LogInformation("Inicia Solicitud GET Books");
            return Ok("practica de prueba");

        }
        [HttpPut(Name = "UpdateBook")]
        public IActionResult Put()
        {
            _logger.LogInformation("Inicia Solicitud GET Books");
            return Ok("practica de prueba");

        }


        [HttpDelete(Name = "DeleteBook")]
        public IActionResult Delete()
        {
            _logger.LogInformation("Inicia Solicitud GET Books");
            return Ok("practica de prueba");

        }


    }




}
