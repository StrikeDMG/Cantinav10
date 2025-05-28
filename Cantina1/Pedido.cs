using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina1
{
    public class Pedido
    {
        public Guid Id { get; private set; }
        public DateTime DataHoraPedido { get; private set; }
        public string NomeCliente { get; set; }
        public List<ItemCarrinho> Itens { get; private set; }
        public decimal ValorTotal { get; private set; }
        public string FormaPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Troco { get; set; }
        public StatusPedido Status { get; set; }

        public Pedido(DateTime dataHora, string nomeCliente, List<ItemCarrinho> itens,
                      string formaPagamento, decimal valorPago = 0, decimal troco = 0)
        {
            Id = Guid.NewGuid();
            DataHoraPedido = dataHora;
            NomeCliente = nomeCliente;
            Itens = new List<ItemCarrinho>(itens);
            FormaPagamento = formaPagamento;
            ValorPago = valorPago;
            Troco = troco;
            Status = StatusPedido.Pendente;

            ValorTotal = Itens.Sum(item => item.PrecoTotal);
        }
        public override string ToString()
        {
            return $"Pedido {Id.ToString().Substring(0, 8)} - {NomeCliente} - {DataHoraPedido:HH:mm} - Status: {Status}";
        }
    }
    public enum StatusPedido
    {
        Pendente,
        EmPreparo,
        Pronto,
        Entregue,
        Cancelado
    }
}
