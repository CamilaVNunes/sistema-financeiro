using SistemaFinanceiro.Domain.Interfaces.ICategoria;
using SistemaFinanceiro.Entities.Entities;
using SistemaFinanceiro.Infrastructure.Repositories.Generics;

namespace SistemaFinanceiro.Infrastructure.Repositories
{
    public class RepositorioCategoria : RepositoryGenerics<Categoria>, ICategoria
    {

    }
}
