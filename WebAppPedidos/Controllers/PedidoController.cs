using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPedidos.Models;

namespace WebAppPedidos.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult ListarPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>() {
            new Pedido(1, "Bolacha", 100, 4, new DateTime(), "João"),
            new Pedido(1, "Arroz", 150, 6.5, new DateTime(), "Maria")
            };

            ViewData["ListaPedidos"] = pedidos;

            return View();
        }
    }
}
