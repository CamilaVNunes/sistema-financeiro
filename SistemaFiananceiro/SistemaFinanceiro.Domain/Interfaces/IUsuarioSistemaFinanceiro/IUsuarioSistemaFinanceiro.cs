using SistemaFinanceiro.Domain.Interfaces.Generics;
using SistemaFinanceiro.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Interfaces.IUsuarioSistemaFinanceiro
{
    public interface IUsuarioSistemaFinanceiro : IGeneric<UsuarioSistemaFinanceiro>
    {
        Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema(int idSistema);
        Task RemoverUsuarioSistema(List<UsuarioSistemaFinanceiro> usuarios);
        Task<UsuarioSistemaFinanceiro> ObeterUsuarioSistemaPorEmail(string emailUsuario);
    }
}
