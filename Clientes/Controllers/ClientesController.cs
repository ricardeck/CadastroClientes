using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clientes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clientes.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            List<Cliente> list = new List<Cliente>();
            list.Add(new Cliente { Nome = "Maria", ValorDevido = 200.00, Vencimento = DateTime.Now, Email = "maria@gmail.com" });
            list.Add(new Cliente { Nome = "Joana", ValorDevido = 400.00, Vencimento = DateTime.Now, Email = "joana@gmail.com" });

            return View(list);
        }
    }
}