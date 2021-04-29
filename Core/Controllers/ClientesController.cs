
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
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerClientes()
        {
            var Clientes = new RepositorioDeUsuarios().GetClientes();
            return Ok(Clientes);
        }
    }
}
