using SistemaFinanceiro.Domain.Interfaces.ICategoria;
using SistemaFinanceiro.Domain.Interfaces.IServicos;
using SistemaFinanceiro.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoria _interfaceCategoria;

        public CategoriaService(ICategoria interfaceCategoria)
        {
            _interfaceCategoria = interfaceCategoria;
        }

        public async  Task AdicionarCategoria(Categoria catagoria)
        {
            var valid = catagoria.ValidyPropertyString(catagoria.Nome, "Nome");
            if (valid)
                await _interfaceCategoria.Add(catagoria);
        }

        public async Task AtualizarCategoria(Categoria catagoria)
        {
            var valid = catagoria.ValidyPropertyString(catagoria.Nome, "Nome");
            if (valid)
                await _interfaceCategoria.Update(catagoria);
        }
    }
}
