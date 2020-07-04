using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPedidos.Models;

namespace WebAppPedidos.Data
{
    public class PedidoContext : DbContext
    {
        public PedidoContext(DbContextOptions<PedidoContext> options) : base(options) { }

        public DbSet<Pedido> Pedido { get; set; }
    }
}
