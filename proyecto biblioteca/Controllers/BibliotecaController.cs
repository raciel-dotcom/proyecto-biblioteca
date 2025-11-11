using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace proyecto_biblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliotecaController : ControllerBase
    {
        private readonly ILogger<BibliotecaController> _logger;

        public BibliotecaController(ILogger<BibliotecaController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetBooks")]
        public IActionResult Get()

        {
            _logger.LogInformation("Inicia Solicitud GET Books");


            return Ok("Prueba");
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
