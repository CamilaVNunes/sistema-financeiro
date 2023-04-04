using SistemaFinanceiro.Domain.Interfaces.Generics;
using SistemaFinanceiro.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Interfaces.IDespesa
{
    public interface IDespesa : IGeneric<Despesa>
    {
        Task<IList<Despesa>> ListaDespesaUsuario(string emailUsuario);
        Task<IList<Despesa>> ListaDespesaUsuarioNaoPagasMesesAnteriores(string emailUsuario);
    }
}
