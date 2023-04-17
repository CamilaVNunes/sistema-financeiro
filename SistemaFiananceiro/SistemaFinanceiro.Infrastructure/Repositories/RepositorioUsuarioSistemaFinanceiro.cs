using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SistemaFinanceiro.Domain.Interfaces.IUsuarioSistemaFinanceiro;
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
    public class RepositorioUsuarioSistemaFinanceiro : RepositoryGenerics<UsuarioSistemaFinanceiro>, IUsuarioSistemaFinanceiro
    {
        private readonly DbContextOptions<ContextBase> _optionsBuilder;

        public RepositorioUsuarioSistemaFinanceiro()
        {
            _optionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema(int idSistema)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                return await
                    data.UsuarioSistemaFinanceiro
                    .Where(s => s.IdSistema == idSistema).AsNoTracking()
                    .ToListAsync();
            }
        }

        public async Task<UsuarioSistemaFinanceiro> ObeterUsuarioSistemaPorEmail(string emailUsuario)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                return await
                    data.UsuarioSistemaFinanceiro
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.EmailUsuario.Equals(emailUsuario));
            }
        }

        public async Task RemoverUsuarioSistema(List<UsuarioSistemaFinanceiro> usuarios)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                data.UsuarioSistemaFinanceiro
               .RemoveRange(usuarios);

                await data.SaveChangesAsync();
            }
        }
    }
}
