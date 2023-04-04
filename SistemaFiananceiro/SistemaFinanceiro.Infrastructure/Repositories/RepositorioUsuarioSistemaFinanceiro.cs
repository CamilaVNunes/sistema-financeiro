using SistemaFinanceiro.Domain.Interfaces.IUsuarioSistemaFinanceiro;
using SistemaFinanceiro.Entities.Entities;
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
        public Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema(int idSistema)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioSistemaFinanceiro> ObeterUsuarioSistemaPorEmail(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        public Task RemoverUsuarioSistema(List<UsuarioSistemaFinanceiro> usuarios)
        {
            throw new NotImplementedException();
        }
    }
}
