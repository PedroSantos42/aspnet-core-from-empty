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
        // GET: /pedido/
        public IActionResult ListarPedidos()
        {
            return View();
        }
        // 
        // GET: /pedido/Welcome?name=Ana 
        public IActionResult Welcome(string name)
        {
            ViewData["name"] = name;
            return View();
        }
    }
}
