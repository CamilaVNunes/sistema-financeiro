using SistemaFinanceiro.Domain.Interfaces.ISistemaFinanceiro;
using SistemaFinanceiro.Entities.Entities;
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
    }
}
