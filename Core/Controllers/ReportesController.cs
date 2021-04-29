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
    public class ReportesController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerReportes()
        {
            var Reportes = new RepositorioDeReportes().GetReportes();
            return Ok(Reportes);
        }
    }
}
