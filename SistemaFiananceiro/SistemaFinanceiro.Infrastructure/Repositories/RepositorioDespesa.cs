using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SistemaFinanceiro.Domain.Interfaces.IDespesa;
using SistemaFinanceiro.Entities.Entities;
using SistemaFinanceiro.Infrastructure.Config;
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
        private readonly DbContextOptions<ContextBase> _optionsBuilder;

        public RepositorioDespesa()
        {
            _optionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<IList<Despesa>> ListaDespesaUsuario(string emailUsuario)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                return await
                   (from s in data.SistemaFinanceiro
                    join c in data.Categoria on s.Id equals c.IdSistema
                    join us in data.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                    join d in data.Despesa on c.Id equals d.IdCategoria
                    where us.EmailUsuario.Equals(emailUsuario) && s.Mes == d.Mes && s.Ano == d.Ano
                    select d).AsNoTracking().ToListAsync();
            }
        }

        public async Task<IList<Despesa>> ListaDespesaUsuarioNaoPagasMesesAnteriores(string emailUsuario)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                return await
                   (from s in data.SistemaFinanceiro
                    join c in data.Categoria on s.Id equals c.IdSistema
                    join us in data.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                    join d in data.Despesa on c.Id equals d.IdCategoria
                    where us.EmailUsuario.Equals(emailUsuario) && d.Mes < DateTime.Now.Month && !d.Pago
                    select d).AsNoTracking().ToListAsync();
            }
        }
    }
}
