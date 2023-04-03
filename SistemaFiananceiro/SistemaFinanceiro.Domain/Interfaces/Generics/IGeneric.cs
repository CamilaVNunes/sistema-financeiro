using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T Obeject);
        Task Delete(T Obeject);
        Task<T> GetEntityById(int Id);
        Task Update(T Obeject);
        Task<List<T>> GetAll();
    }
}
