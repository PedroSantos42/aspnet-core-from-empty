﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppPedidos.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        
        [Required]
        public string Produto { get; set; }
        
        public int Quantidade { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        public double Valor { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        
        public string Fornecedor { get; set; }

        public Pedido() { }

        public Pedido(int pedidoId, string produto, int quantidade, double valor, DateTime data, string fornecedor)
        {
            PedidoId = pedidoId;
            Produto = produto;
            Quantidade = quantidade;
            Valor = valor;
            Data = data;
            Fornecedor = fornecedor;
        }

        public void CadastrarPedido(Pedido pedido)
        {
            Console.WriteLine($"Pedido {pedido.PedidoId} cadastrado...");
        }

        public List<Pedido> ListarPedidos()
        {
            List<Pedido> list = new List<Pedido>();
            return list;
        }
    }
}
