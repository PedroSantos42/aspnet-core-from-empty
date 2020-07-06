using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPedidos.Data;
using WebAppPedidos.Models;

namespace WebAppPedidos.Controllers
{
    // Gustavo Anderson
    public class PedidoController : Controller
    {
        private readonly PedidoContext _context;

        public PedidoController(PedidoContext context)
        {
            _context = context;
        }
        public IActionResult CadastrarPedido()
        {
            ViewData["existePedido"] = TempData["existePedidoInfo"];
            return View();
        }
        public IActionResult ListarPedidos()
        {
            List<Pedido> lista;
            try
            {
                lista = _context.Pedido.Where(p => p != null).ToList();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            ViewData["ListaPedidos"] = lista;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SalvarPedido([Bind("PedidoId, Produto, Quantidade, Valor, Data, Fornecedor")] Pedido pedido)
        {
            try
            {
                Pedido p = _context.Pedido.FirstOrDefault(ped => ped.Produto == pedido.Produto);

                if (p != null)
                {
                    TempData["existePedidoInfo"] = "Pedido já foi cadastrado";
                    return RedirectToAction(nameof(CadastrarPedido));
                }
                else
                {
                    pedido.Data = DateTime.Now;
                    _context.Add(pedido);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception e) { throw e; }
            return RedirectToAction(nameof(ListarPedidos));
        }
    }
}