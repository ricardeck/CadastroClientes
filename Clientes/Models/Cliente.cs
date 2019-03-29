using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "{0} não pode ser deixado em branco")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "{0} não pode ser deixado em branco")]
        [Display(Name = "Valor da Dívida")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double ValorDevido { get; set; }

        [Required(ErrorMessage = "{0} não pode ser deixado em branco")]
        [Display(Name = "Data de Vencimento")]
        [DataType(DataType.Date)]
        public DateTime Vencimento { get; set; }

        [Required(ErrorMessage = "{0} não pode ser deixado em branco")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Idade")]
        [DisplayFormat(DataFormatString = "{0:F0}")]
        public double Idade { get; set; }

        [Required(ErrorMessage = "{0} não pode ser deixado em branco")]
        [EmailAddress(ErrorMessage = "Entre com um email, válido")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        public void CalculaIdade()
        {
            double valorIdade = DateTime.Today.Year - Nascimento.Date.Year;
            if (Nascimento.Month > DateTime.Today.Month || (Nascimento.Month == DateTime.Today.Month && Nascimento.Day > DateTime.Today.Day))
            {
                valorIdade--;
            }
            Idade = valorIdade;
        }
    }
}
