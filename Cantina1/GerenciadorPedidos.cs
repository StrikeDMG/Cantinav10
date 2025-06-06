﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina1
{
    public static class GerenciadorPedidos
    {
        private static List<Pedido> listaDePedidos = new List<Pedido>();
        private static readonly object lockObj = new object();
        private static int proximoIdPedido = 1;

        public static event EventHandler<PedidoAdicionadoEventArgs>? PedidoAdicionado;

        public static void AdicionarPedido(Pedido novoPedido)
        {
            if (novoPedido == null) throw new ArgumentNullException(nameof(novoPedido));

            lock (lockObj)
            {
                novoPedido.DefinirId(proximoIdPedido);
                listaDePedidos.Add(novoPedido);
                proximoIdPedido++;
            }
            OnPedidoAdicionado(novoPedido);
        }

        public static List<Pedido> ObterTodosPedidos()
        {
            lock (lockObj)
            {
                return new List<Pedido>(listaDePedidos);
            }
        }


        public static Pedido? ObterPedidoPorId(int id)
        {
            lock (lockObj)
            {
                return listaDePedidos.FirstOrDefault(p => p.ID == id);
            }
        }


        public static void AtualizarStatusPedido(int pedidoId, StatusPedido novoStatus)
        {
            lock (lockObj)
            {
                var pedido = listaDePedidos.FirstOrDefault(p => p.ID == pedidoId);
                if (pedido != null)
                {
                    pedido.Status = novoStatus;
                }
            }
        }

        private static void OnPedidoAdicionado(Pedido pedido)
        {
            PedidoAdicionado?.Invoke(null, new PedidoAdicionadoEventArgs(pedido));
        }
    }

    public class PedidoAdicionadoEventArgs : EventArgs
    {
        public Pedido NovoPedido { get; private set; }
        public PedidoAdicionadoEventArgs(Pedido pedido)
        {
            NovoPedido = pedido;
        }
    }
}
