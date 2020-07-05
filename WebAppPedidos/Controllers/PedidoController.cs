using Microsoft.AspNetCore.Mvc;
using System;
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
            List<Pedido> list;

            try
            {
                list = _context.Pedido.Where(p => p != null).ToList();
            }
            catch (Exception e) { throw e; }

            ViewData["ListaPedidos"] = list;

            return View();
        }

        public IActionResult CadastrarPedido()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Salvar([Bind("PedidoId, Produto, Quantidade, Valor, Data, Fornecedor")] Pedido pedido)
        {
            try
            {
                Pedido p = _context.Pedido.FirstOrDefault(x => x.Produto == pedido.Produto);

                if (p != null)
                {
                    ViewBag.Message = "Falha ao cadastrar: Produto existente.";
                    return RedirectToAction(nameof(CadastrarPedido));
                }
                else
                {
                    _context.Add(pedido);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception e) { throw e; }
            return RedirectToAction(nameof(ListarPedidos));
        }

        public IActionResult EditarPedido(int id)
        {
            var pedido = _context.Pedido.FirstOrDefault(p => p.PedidoId == id);
            if (pedido != null)
            {
                ViewData["pedido"] = pedido;
            }
            return View();
        }

        public IActionResult Editar(Pedido pedido)
        {
            pedido.Data = DateTime.Now;
            _context.Pedido.Update(pedido);
            _context.SaveChanges();
            return RedirectToAction(nameof(ListarPedidos));
        }

        public IActionResult RemoverPedido(int id)
        {
            var pedido = _context.Pedido.FirstOrDefault(p => p.PedidoId == id);
            _context.Pedido.Remove(pedido);
            _context.SaveChanges();
            return RedirectToAction(nameof(ListarPedidos));
        }
    }
}