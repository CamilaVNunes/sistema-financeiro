using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Domain.Interfaces.ICategoria;
using SistemaFinanceiro.Entities.Entities;
using SistemaFinanceiro.Infrastructure.Config;
using SistemaFinanceiro.Infrastructure.Repositories.Generics;
using System.ComponentModel;

namespace SistemaFinanceiro.Infrastructure.Repositories
{
    public class RepositorioCategoria : RepositoryGenerics<Categoria>, ICategoria
    {
        private readonly DbContextOptions<ContextBase> _optionsBuilder;

        public RepositorioCategoria()
        {
            _optionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<IList<Categoria>> ListarCategoriasUsuario(string emailUsuario)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                return await
                    (from s in data.SistemaFinanceiro
                     join c in data.Categoria on s.Id equals c.IdSistema
                     join us in data.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                     where us.EmailUsuario.Equals(emailUsuario) && us.SistemaAtual
                     select c ).AsNoTracking().ToListAsync();
            }
        }
    }
}
