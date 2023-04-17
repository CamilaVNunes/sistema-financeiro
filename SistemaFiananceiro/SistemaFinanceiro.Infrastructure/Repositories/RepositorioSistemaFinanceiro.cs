using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SistemaFinanceiro.Domain.Interfaces.ISistemaFinanceiro;
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
    public class RepositorioSistemaFinanceiro : RepositoryGenerics<Financeiro>, ISistemaFinanceiro
    {
        private readonly DbContextOptions<ContextBase> _optionsBuilder;

        public RepositorioSistemaFinanceiro()
        {
            _optionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<IList<Financeiro>> ListaSistemasUsuario(string emailUsuario)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                return await
                   (from s in data.SistemaFinanceiro
                    join us in data.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                    where us.EmailUsuario.Equals(emailUsuario)
                    select s).AsNoTracking().ToListAsync();
            }
        }
    }
}
