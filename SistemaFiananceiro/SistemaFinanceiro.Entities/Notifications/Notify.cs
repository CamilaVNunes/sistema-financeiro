using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Entities.Notifications
{
    public class Notify
    {
        public Notify()
        {
            Notifies = new List<Notify>();
        }

        [NotMapped]
        public string NameProperty { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notify> Notifies { get; set; }

        public bool ValidyPropertyString(string value, string nameProperty)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notifies.Add(new Notify
                {
                    NameProperty = nameProperty,
                    Message = "Campo Obrigatório"
                });
                return false;
            }

            return true;
        }

        public bool ValidyPropertyInteger(int value, string nameProperty)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notifies.Add(new Notify
                {
                    NameProperty = nameProperty,
                    Message = "Campo Obrigatório"
                });
                return false;
            }

            return true;
        }
    }
}
