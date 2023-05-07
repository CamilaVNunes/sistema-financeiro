using SistemaFinanceiro.Domain.Interfaces.IServicos;
using SistemaFinanceiro.Domain.Interfaces.ISistemaFinanceiro;
using SistemaFinanceiro.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Services
{
    public class SistemaFinanceiroService : ISistemaFinanceiroService
    {
        private readonly ISistemaFinanceiro _interfaceSistemaFinanceiro;

        public SistemaFinanceiroService(ISistemaFinanceiro interfaceSistemaFinanceiro)
        {
            _interfaceSistemaFinanceiro = interfaceSistemaFinanceiro;
        }

        public async Task AdicionarSistemaFinanceiro(Financeiro sistemaFinanceiro)
        {
            var valid = sistemaFinanceiro.ValidyPropertyString(sistemaFinanceiro.Nome, "Nome");

            if (valid)
            {
                var data = DateTime.Now;

                sistemaFinanceiro.DiaFechamento = 1;
                sistemaFinanceiro.Ano = data.Year;
                sistemaFinanceiro.Mes = data.Month;
                sistemaFinanceiro.AnoCopia = data.Year;
                sistemaFinanceiro.MesCopia = data.Month;
                sistemaFinanceiro.GerarCopiaDespesa = true;

                await _interfaceSistemaFinanceiro.Add(sistemaFinanceiro);
            }
        }

        public async Task AtualizarSistemaFinanceiro(Financeiro sistemaFinanceiro)
        {
            var valid = sistemaFinanceiro.ValidyPropertyString(sistemaFinanceiro.Nome, "Nome");

            if (valid)
            {
                sistemaFinanceiro.DiaFechamento = 1;
                await _interfaceSistemaFinanceiro.Update(sistemaFinanceiro);
            }
        }
    }
}
