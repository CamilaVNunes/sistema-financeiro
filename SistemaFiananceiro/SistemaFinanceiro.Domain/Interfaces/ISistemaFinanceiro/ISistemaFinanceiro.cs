﻿using SistemaFinanceiro.Domain.Interfaces.Generics;
using SistemaFinanceiro.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Interfaces.ISistemaFinanceiro
{
    public interface ISistemaFinanceiro : IGeneric<Financeiro>
    {
        Task<IList<Financeiro>> ListaSistemasUsuario(string emailUsuario);
    }
}
