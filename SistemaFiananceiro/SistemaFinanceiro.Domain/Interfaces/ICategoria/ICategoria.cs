using SistemaFinanceiro.Domain.Interfaces.Generics;
using SistemaFinanceiro.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Interfaces.ICategoria
{
    public interface ICategoria : IGeneric<Categoria>
    {
        Task<IList<Categoria>> ListarCategoriasUsuario(string emailUsuario);
    }
}
