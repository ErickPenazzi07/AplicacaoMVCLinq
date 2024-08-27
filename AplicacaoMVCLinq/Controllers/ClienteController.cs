using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getClientes()
        {
            Cliente c1 = new Cliente(1, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 2));
            Cliente c2 = new Cliente(2, "João", "joao@example.com", "1234-5678", new DateOnly(2001, 3, 3));
            Cliente c3 = new Cliente(3, "Gustavo", "gustavo@example.com", "1234-5678", new DateOnly(1999, 5, 6));
            Cliente c4 = new Cliente(4, "Marcio", "marcio@example.com", "1234-5678", new DateOnly(1998, 2, 7));
            Cliente c5 = new Cliente(4, "Marcio", "marcio@example.com", "1234-5678", new DateOnly(1998, 2, 7));


            List<Cliente> ListarCliente = new List<Cliente>();

            ListarCliente.Add(c1);
            ListarCliente.Add(c2);
            ListarCliente.Add(c3);
            ListarCliente.Add(c4);

            return View(ListarCliente);
        }


    }
}
