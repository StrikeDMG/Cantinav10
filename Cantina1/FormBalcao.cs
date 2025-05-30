using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina1
{
    public partial class FormBalcao : Form
    {
        public FormBalcao()
        {
            InitializeComponent();
        }

        private void FormBalcao_Load(object sender, EventArgs e)
        {
            CarregarPedidosIniciais();
            GerenciadorPedidos.PedidoAdicionado += AoReceberNovoPedidoDoGerenciador;
        }
        private void AoReceberNovoPedidoDoGerenciador(object? sender, PedidoAdicionadoEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => AdicionarPedidoNaListaVisual(e.NovoPedido)));
            }
            else
            {
                AdicionarPedidoNaListaVisual(e.NovoPedido);
            }
        }

        private void CarregarPedidosIniciais()
        {
            listBoxPedidosPendentes.Items.Clear();

            var pedidosParaExibir = GerenciadorPedidos.ObterTodosPedidos()
                .Where(p => p.Status == StatusPedido.Pendente || p.Status == StatusPedido.EmPreparo)
                .OrderBy(p => p.DataHoraPedido)
                .ToList();

            foreach (var pedido in pedidosParaExibir)
            {
                AdicionarPedidoNaListaVisual(pedido);
            }
        }

        private void AdicionarPedidoNaListaVisual(Pedido pedido)
        {
            listBoxPedidosPendentes.Items.Add(pedido);
        }

        private void listBoxPedidosPendentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPedidosPendentes.SelectedItem is Pedido pedidoSelecionado)
            {
                // Aqui você populacria Labels/TextBoxes com os detalhes do pedidoSelecionado
                // Ex: lblClienteDetalhe.Text = pedidoSelecionado.NomeCliente;
                //     lblStatusDetalhe.Text = pedidoSelecionado.Status.ToString();
                //     // Para os itens, você pode usar outra ListBox ou um TextBox multiline
                //     listBoxItensDetalhe.Items.Clear();
                //     foreach(var item in pedidoSelecionado.Itens)
                //     {
                //         listBoxItensDetalhe.Items.Add($"{item.Quantidade}x {item.Produto.Nome} - {item.PrecoTotal:C}");
                //     }
                this.Text = $"Balcão - Pedido: {pedidoSelecionado.ID}";
            }
            else
            {
                this.Text = "Balcão";
            }
        }

        private void FormBalcao_FormClosing(object sender, FormClosingEventArgs e)
        {
            GerenciadorPedidos.PedidoAdicionado -= AoReceberNovoPedidoDoGerenciador;
        }

        private void btnMarcarEmPreparo_Click(object sender, EventArgs e)
        {
            if (listBoxPedidosPendentes.SelectedItem is Pedido pedidoSel)
            {
                GerenciadorPedidos.AtualizarStatusPedido(pedidoSel.ID, StatusPedido.EmPreparo);
                CarregarPedidosIniciais();
            }
        }

        private void btnMarcarPronto_Click(object sender, EventArgs e)
        {
            if (listBoxPedidosPendentes.SelectedItem is Pedido pedidoSel)
            {
                GerenciadorPedidos.AtualizarStatusPedido(pedidoSel.ID, StatusPedido.Pronto);
                CarregarPedidosIniciais();
            }
        }
    }
}
