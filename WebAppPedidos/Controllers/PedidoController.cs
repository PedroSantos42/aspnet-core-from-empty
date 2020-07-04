using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPedidos.Data;
using WebAppPedidos.Models;

namespace WebAppPedidos.Controllers
{
    public class PedidoController : Controller
    {
        private readonly PedidoContext _context;

        public PedidoController(PedidoContext context)
        {
            _context = context;
        }

        public IActionResult ListarPedidos()
        {
            List<Pedido> list = _context.Pedido.Where(p => p.PedidoId > 0).ToList();

            ViewData["ListaPedidos"] = list;

            return View();
        }

        public IActionResult CadastrarPedido()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SalvarPedido([Bind("PedidoId, Produto, Quantidade, Valor, Data, Fornecedor")] Pedido pedido)
        {
            _context.Add(pedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListarPedidos));
        }
    }
}