using SistemaFinanceiro.Domain.Interfaces.IDespesa;
using SistemaFinanceiro.Domain.Interfaces.IServicos;
using SistemaFinanceiro.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Services
{
    public class DespesasService : IDespesaService
    {
        private readonly IDespesa _interfaceDespesa;
        public DespesasService(IDespesa interfaceDespesa)
        {
            _interfaceDespesa = interfaceDespesa;
        }

        public async Task AdicionarDespesa(Despesa despesa)
        {
            var data = DateTime.UtcNow;
            despesa.DataCadastro = data;
            despesa.Ano = data.Year;
            despesa.Mes = data.Month;

            var valid = despesa.ValidyPropertyString(despesa.Nome, "Nome");
            if (valid)
                await _interfaceDespesa.Add(despesa);
        }

        public async Task AtualizarDespesa(Despesa despesa)
        {
            var data = DateTime.UtcNow;
            despesa.DataAlteracao = data;

            if (despesa.Pago)
            {
                despesa.DataPagamento = data;
            }

            var valid = despesa.ValidyPropertyString(despesa.Nome, "Nome");
            if (valid)
                await _interfaceDespesa.Update(despesa);
        }
    }
}
