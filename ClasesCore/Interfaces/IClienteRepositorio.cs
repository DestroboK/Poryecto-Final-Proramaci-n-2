using ClasesCore.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCore.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<IEnumerable<Clientes>> GetClientes();
    }
}
