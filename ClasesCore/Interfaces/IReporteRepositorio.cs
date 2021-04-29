using ClasesCore.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCore.Interfaces
{
    public interface IReporteRepositorio
    {
        Task<IEnumerable<Reportes>> GetReportes();
    }
}
