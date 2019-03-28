using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clientes.Models
{
    public class Cliente
    {
        public String Nome { get; set; }
        public double ValorDevido { get; set; }
        public DateTime Vencimento { get; set; }
        public String Email { get; set; }


    }
}
