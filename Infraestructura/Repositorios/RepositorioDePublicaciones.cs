using ClasesCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesCore.Entidades;
using System.Threading.Tasks;
namespace Infraestructura.Repositorios
{
    public class Post_Repositorio : IPostRepositorio
    {
        public async Task<IEnumerable<Publicacion>> GetPublicaciones()
        {
            var Publicaciones = Enumerable.Range(1, 10).Select(x => new Publicacion
            {
                //ejemplo con data dummy 
                Id = x,
                Descripcion = $"Descripcion generica {x}",
                Fecha = DateTime.Now,
                Imagen = $"https://misapis.com/{x}",
                IdUsuario = x*2
                
            });
            await Task.Delay(10);
            return Publicaciones;

        }
    }
}
