using SistemaFinanceiro.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Interfaces.IServicos
{
    public interface ISistemaFinanceiroService
    {
        Task AdicionarSistemaFinanceiro(Financeiro sistemaFinanceiro);

        Task AtualizarSistemaFinanceiro(Financeiro sistemaFinanceiro);
    }
}
