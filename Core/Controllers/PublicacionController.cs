using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Infraestructura.Repositorios;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicacionController : ControllerBase
    {   
        [HttpGet]
        public IActionResult ObtenerPublicaciones()
        {
            var Publis = new Post_Repositorio().GetPublicaciones();
            return Ok(Publis);
        }
    }
}
