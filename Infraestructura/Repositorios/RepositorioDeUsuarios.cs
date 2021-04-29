using ClasesCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesCore.Entidades;
using System.Threading.Tasks;
namespace Infraestructura.Repositorios
{
    public class RepositorioDeUsuarios : IClienteRepositorio
    {
        public async Task<IEnumerable<Clientes>> GetClientes()
        {
            var Clientes = Enumerable.Range(1, 100).Select(x => new Clientes
            {
                //ejemplo con data dummy 
                IdCliente = x * 2,
                Nombre = $"Nombre generico {x}",
                Apellido = $"Apellido {x}",
                Imagen = $"https://misapis.com/{x}",

            });
            await Task.Delay(10);
            return Clientes;

        }
    }
}