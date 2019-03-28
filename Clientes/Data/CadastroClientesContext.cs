using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Clientes.Models;

namespace CadastroClientes.Models
{
    public class CadastroClientesContext : DbContext
    {
        public CadastroClientesContext (DbContextOptions<CadastroClientesContext> options)
            : base(options)
        {
        }

        public DbSet<Clientes.Models.Cliente> Cliente { get; set; }
    }
}
