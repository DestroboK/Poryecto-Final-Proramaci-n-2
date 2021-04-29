using ClasesCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesCore.Entidades;
using System.Threading.Tasks;
namespace Infraestructura.Repositorios
{
    public class RepositorioDeReportes : IReporteRepositorio
    {

        public async Task<IEnumerable<Reportes>> GetReportes()
    {
        var Reportes = Enumerable.Range(1, 19).Select(x => new Reportes
        {
            //ejemplo con data dummy 
            IdReporte = x,
            IdCliente = x * 2,
            Nombre = $"Nombre generico {x}",
            Descripcion = $"Descripcion generica {x}",
            Tecnico_asignado = $"Tecnico {x}"

        });
        await Task.Delay(10);
        return Reportes;

        }
    }   
}

