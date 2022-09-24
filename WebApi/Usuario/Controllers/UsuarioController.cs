using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Usuario.Model;


namespace Usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsuarioController : ControllerBase
    
    {
        private static List<usuario> Usuarios(){

            return new List<usuario>{
                new usuario {Name ="John", Id =1, DataNascimento= new DateTime(2012, 1, 1)}
            };
        }

        [HttpGet]

        public IActionResult Get()
        {
             return Ok(Usuarios());
        }
        [HttpPost]
        public IActionResult Post(usuario usuario)
        {
             var usuarios = Usuarios();
             usuarios.Add(usuario);
             return Ok(usuarios);
        }
    }
}