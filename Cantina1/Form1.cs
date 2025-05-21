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
    public partial class Form1 : Form
    {
        private List<ItemCarrinho> carrinhoItens = new List<ItemCarrinho>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(new Produto(1, "Coxinha", 5.00m, 20));
            listBox1.Items.Add(new Produto(2, "Pastel", 6.00m, 20));
            listBox1.Items.Add(new Produto(3, "Refrigerante", 4.50m, 40));
            listBox1.Items.Add(new Produto(4, "Suco", 3.00m, 30));
            listBox1.Items.Add(new Produto(5, "Brigadeiro", 2.50m, 15));

            carrinhoItens.Clear();
            AtualizarDisplayCarrinho();
            AtualizarTotalCarrinho();
            AtualizarVisibilidadeCamposDinheiro();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Produto produtoSelecionadoDaLista = (Produto)listBox1.SelectedItem;
                ItemCarrinho? itemParaSelecionarNoCarrinho = null;

                if (produtoSelecionadoDaLista.QuantidadeEmEstoque <= 0)
                {
                    MessageBox.Show($"Desculpe, '{produtoSelecionadoDaLista.Nome}' está esgotado.", "Produto Esgotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ItemCarrinho? itemExistenteNoCarrinho = carrinhoItens.FirstOrDefault(item => item.Produto.Id == produtoSelecionadoDaLista.Id);
                if (itemExistenteNoCarrinho != null)
                {
                    if (itemExistenteNoCarrinho.Quantidade + 1 > produtoSelecionadoDaLista.QuantidadeEmEstoque)
                    {
                        MessageBox.Show($"Não há estoque suficiente de '{produtoSelecionadoDaLista.Nome}' para adicionar mais unidades.\n" +
                                       $"Disponível: {produtoSelecionadoDaLista.QuantidadeEmEstoque}, No carrinho: {itemExistenteNoCarrinho.Quantidade}",
                                       "Estoque Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    itemExistenteNoCarrinho.IncrementarQuantidade();
                    itemParaSelecionarNoCarrinho = itemExistenteNoCarrinho;
                }
                else
                {
                    ItemCarrinho novoItem = new ItemCarrinho(produtoSelecionadoDaLista, 1);
                    carrinhoItens.Add(novoItem);
                    itemParaSelecionarNoCarrinho = novoItem;
                }
                AtualizarDisplayCarrinho();
                AtualizarTotalCarrinho();
                if (itemParaSelecionarNoCarrinho != null)
                {
                    SelecionarItemNoCarrinho(itemParaSelecionarNoCarrinho);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto da lista para adicionar.", "Aviso");
            }
        }

        private void SelecionarItemNoCarrinho(ItemCarrinho itemParaSelecionar)
        {
            if (itemParaSelecionar == null) return;

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i] is ItemCarrinho itemNaLista)
                {

                    if (itemNaLista.Produto.Equals(itemParaSelecionar.Produto))
                    {
                        listBox2.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                ItemCarrinho itemSelecionadoParaRemover = (ItemCarrinho)listBox2.SelectedItem;
                ItemCarrinho? itemParaSelecionarAposRemocao = null;

                bool aindaResta = itemSelecionadoParaRemover.DecrementarQuantidade();

                if (!aindaResta)
                {
                    carrinhoItens.Remove(itemSelecionadoParaRemover);

                }
                else
                {

                    itemParaSelecionarAposRemocao = itemSelecionadoParaRemover;
                }

                AtualizarDisplayCarrinho();
                AtualizarTotalCarrinho();


                if (itemParaSelecionarAposRemocao != null)
                {
                    SelecionarItemNoCarrinho(itemParaSelecionarAposRemocao);
                }


            }
            else
            {
                MessageBox.Show("Selecione um item do carrinho para remover.", "Aviso");
            }
        }

        private void AtualizarDisplayCarrinho()
        {
            listBox2.Items.Clear();

            foreach (ItemCarrinho item in carrinhoItens)
            {
                listBox2.Items.Add(item);
            }


        }


        private void AtualizarTotalCarrinho()
        {
            decimal total = 0;
            foreach (ItemCarrinho item in carrinhoItens)
            {
                total += item.PrecoTotal;
            }

            txtTotal.Text = $"Total: R$ {total:F2}";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (carrinhoItens.Count == 0)
            {
                MessageBox.Show("O carrinho está vazio. Adicione itens antes de finalizar a compra.", "Carrinho Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string nomeDoCliente = txtClientName.Text.Trim();
            if (string.IsNullOrWhiteSpace(nomeDoCliente)) 
            {
                nomeDoCliente = "Cliente";
            }
            DateTime dataHoraDoPedido = DateTime.Now;
            string formaPagamentoSelecionada = "";
            decimal valorTotalCompra = carrinhoItens.Sum(item => item.PrecoTotal);
            string detalhesPagamentoInfo = "";
            decimal trocoCalculado = 0m;

            if (rbCash.Checked)
            {
                formaPagamentoSelecionada = "Dinheiro";
                if (!decimal.TryParse(txtPaidValue.Text, out decimal valorPago) || valorPago <= 0)
                {
                    MessageBox.Show("Por favor, insira um valor pago válido.", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaidValue.Focus();
                    return;
                }

                if (valorPago < valorTotalCompra)
                {
                    MessageBox.Show($"O valor pago (R$ {valorPago:F2}) é insuficiente para cobrir o total da compra (R$ {valorTotalCompra:F2}).", "Valor Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaidValue.Focus();
                    return;
                }
                trocoCalculado = valorPago - valorTotalCompra;
                lblChange.Text = $"Troco: R$ {trocoCalculado:F2}";
                detalhesPagamentoInfo = $"\nForma de Pagamento: {formaPagamentoSelecionada}\nValor Pago: R$ {valorPago:F2}\nTroco: R$ {trocoCalculado:F2}";
            }
            else if (rbDebit.Checked)
            {
                formaPagamentoSelecionada = "Cartão de Débito";
                detalhesPagamentoInfo = $"\nForma de Pagamento: {formaPagamentoSelecionada}";
            }
            else if (rbCredit.Checked)
            {
                formaPagamentoSelecionada = "Cartão de Crédito";
                detalhesPagamentoInfo = $"\nForma de Pagamento: {formaPagamentoSelecionada}";
            }
            else if (rbPix.Checked)
            {
                formaPagamentoSelecionada = "PIX";
                detalhesPagamentoInfo = $"\nForma de Pagamento: {formaPagamentoSelecionada}";
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento.", "Forma de Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ItemCarrinho itemVendido in carrinhoItens)
            {
                Produto? produtoOriginalNaLista = listBox1.Items.OfType<Produto>()
                                                    .FirstOrDefault(p => p.Id == itemVendido.Produto.Id);
                if (produtoOriginalNaLista != null)
                {
                    if (produtoOriginalNaLista.QuantidadeEmEstoque >= itemVendido.Quantidade)
                    {
                        produtoOriginalNaLista.QuantidadeEmEstoque -= itemVendido.Quantidade;
                    }
                    else
                    {
                        MessageBox.Show($"Erro de estoque inconsistente para {produtoOriginalNaLista.Nome}. Operação abortada.", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            listBox1.BeginUpdate();
            var produtosParaReexibir = new List<Produto>();
            foreach (Produto prod in listBox1.Items)
            {
                produtosParaReexibir.Add(prod);
            }
            listBox1.Items.Clear();
            foreach (Produto prod in produtosParaReexibir)
            {
                listBox1.Items.Add(prod);
            }
            listBox1.EndUpdate();

            int totalUnidades = carrinhoItens.Sum(item => item.Quantidade);
            string resumoPedido = $"Pedido Finalizado com Sucesso para: {nomeDoCliente}!\n\n" +
                                  $"Data/Hora: {dataHoraDoPedido:dd/MM/yyyy HH:mm:ss}\n\n" +
                                  $"Total de Produtos Diferentes: {carrinhoItens.Count}\n" +
                                  $"Total de Unidades: {totalUnidades}\n" +
                                  $"Valor Total da Compra: R$ {valorTotalCompra:F2}" +
                                  $"{detalhesPagamentoInfo}\n\n" +
                                  $"Obrigado pela sua compra!";
            MessageBox.Show(resumoPedido, "Compra Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            carrinhoItens.Clear();
            AtualizarDisplayCarrinho();
            AtualizarTotalCarrinho();

            txtClientName.Clear();
            txtPaidValue.Clear();
            lblChange.Text = "Troco: R$ 0,00";

        }

        private void AtualizarVisibilidadeCamposDinheiro()
        {
            bool pagamentoEmDinheiro = rbCash.Checked;
            lblPaidValue.Visible = pagamentoEmDinheiro;
            txtPaidValue.Visible = pagamentoEmDinheiro;
            lblChange.Visible = pagamentoEmDinheiro;

            if (!pagamentoEmDinheiro)
            {
                txtPaidValue.Clear();
                lblChange.Text = "Troco: R$ 0,00";
            }
        }

        private void PaymentMethod_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarVisibilidadeCamposDinheiro();
        }

        private void rbDebit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPix_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblChange_Click(object sender, EventArgs e)
        {

        }
    }
}