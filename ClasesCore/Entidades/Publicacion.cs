using System;
namespace ClasesCore.Entidades
{
    public class Publicacion
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

    }
}
