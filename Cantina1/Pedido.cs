using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina1
{
    public class Pedido
    {
        public int ID { get; private set; }
        public DateTime DataHoraPedido { get; private set; }
        public string NomeCliente { get; set; }
        public List<ItemCarrinho> Itens { get; private set; }
        public decimal ValorTotal { get; private set; }
        public string FormaPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Troco { get; set; }
        public StatusPedido Status { get; set; }
        public DateTime? DataHoraConclusao { get; set; }

        public Pedido(DateTime dataHora, string nomeCliente, List<ItemCarrinho> itens,
                      string formaPagamento, decimal valorPago = 0, decimal troco = 0)
        {
            DataHoraPedido = dataHora;
            NomeCliente = nomeCliente;
            Itens = new List<ItemCarrinho>(itens);
            FormaPagamento = formaPagamento;
            ValorPago = valorPago;
            Troco = troco;
            Status = StatusPedido.Pendente;
            DataHoraConclusao = null;
            ValorTotal = Itens.Sum(item => item.PrecoTotal);
        }
        internal void DefinirId(int id)
        {
            if (this.ID == 0)
            {
                this.ID = id;
            }
        }

        public override string ToString()
        {
            return $"Pedido Nº {ID} - {NomeCliente} - {DataHoraPedido:HH:mm} - Status: {Status}";
        }

        public string GerarExtratoCompleto()
        {
            StringBuilder extrato = new StringBuilder();
            extrato.AppendLine($"--- Pedido Nº {ID} ---");
            extrato.AppendLine($"Cliente: {NomeCliente}");
            extrato.AppendLine($"Solicitado em: {DataHoraPedido:dd/MM/yyyy HH:mm:ss}");

            if (DataHoraConclusao.HasValue)
            {
                extrato.AppendLine($"Pronto em: {DataHoraConclusao.Value:dd/MM/yyyy HH:mm:ss}");
            }
            extrato.AppendLine($"Status: {Status}");
            extrato.AppendLine("--- Itens ---");
            foreach (var item in Itens)
            {
                extrato.AppendLine($"{item.Quantidade}x {item.Produto.Nome} - {item.PrecoTotal:C}");
            }
            extrato.AppendLine("--------------------");
            extrato.AppendLine($"Valor Total: {ValorTotal:C}");

            if (FormaPagamento == "Dinheiro")
            {
                extrato.AppendLine($"Forma de Pagamento: {FormaPagamento}");
                extrato.AppendLine($"Valor Pago: {ValorPago:C}");
                extrato.AppendLine($"Troco: {Troco:C}");
            }
            else
            {
                extrato.AppendLine($"Forma de Pagamento: {FormaPagamento}");
            }
            extrato.AppendLine("--------------------");
            return extrato.ToString();
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
