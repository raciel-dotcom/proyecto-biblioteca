using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using proyecto_biblioteca.BusinessLogic.Models;
using proyecto_biblioteca.Controllers;
using proyecto_biblioteca.DataBase;


namespace IniciodesesionController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IniciodesesionController : ControllerBase
    {
        private readonly ILogger<IniciodesesionController> _logger;
        private readonly AppDbContex _Context;

        public IniciodesesionController(ILogger<IniciodesesionController> logger, AppDbContex Context)
        {
            _logger = logger;
            _Context = Context;
        }
        [HttpPost(Name = "LOGGIN")]
        public async Task<ActionResult >Post(LoginData payload) 
            
        {
            _logger.LogInformation("Inicia Solicitud GET Books");
            if (payload.validator())
            {
               var Result = await _Context.User.Where(U => U.UserLogin == payload.User && U.Password == payload.Password).ToListAsync();
                if (Result.Count == 0 || Result == null) { return BadRequest("Usuario no encontrado"); }
               return Ok("validacionespasadas");
            }
                
            else return BadRequest("Usuario y Contraseña Requeridos");
           
            return Ok("practica de prueba");
        }


    }



}
