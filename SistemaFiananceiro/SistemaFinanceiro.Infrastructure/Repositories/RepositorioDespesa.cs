using SistemaFinanceiro.Domain.Interfaces.IDespesa;
using SistemaFinanceiro.Entities.Entities;
using SistemaFinanceiro.Infrastructure.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Infrastructure.Repositories
{
    public class RepositorioDespesa : RepositoryGenerics<Despesa>, IDespesa
    {
        public Task<IList<Despesa>> ListaDespesaUsuario(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Despesa>> ListaDespesaUsuarioNaoPagasMesesAnteriores(string emailUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
