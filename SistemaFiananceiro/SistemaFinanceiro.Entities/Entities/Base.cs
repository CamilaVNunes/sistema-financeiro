using SistemaFinanceiro.Entities.Notifications;
using System.ComponentModel.DataAnnotations;

namespace SistemaFinanceiro.Entities.Entities
{
    public class Base : Notify
    {
        [Display(Name="Código")]
        public int Id{ get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
