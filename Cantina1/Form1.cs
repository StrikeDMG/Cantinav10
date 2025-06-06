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
        private FormBalcao? formBalcaoInstance = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(new Produto(1, "P�o de Queijo", 3.50m, 20));
            listBox1.Items.Add(new Produto(2, "Coxinha", 5.00m, 20));
            listBox1.Items.Add(new Produto(3, "Pastel [Carne]", 6.00m, 40));
            listBox1.Items.Add(new Produto(4, "Pastel [Queijo]", 5.50m, 30));
            listBox1.Items.Add(new Produto(5, "Suco Natural [300 mL]", 4.00m, 15));
            listBox1.Items.Add(new Produto(6, "Refrigerante [350 mL]", 4.50m, 15));
            listBox1.Items.Add(new Produto(7, "Hamb�rguer Simples", 8.00m, 15));
            listBox1.Items.Add(new Produto(8, "X-Burguer", 9.00m, 15));
            listBox1.Items.Add(new Produto(9, "X-Tudo", 12.00m, 15));
            listBox1.Items.Add(new Produto(10, "�gua Mineral [500 mL]", 4.00m, 15));

            carrinhoItens.Clear();
            AtualizarDisplayCarrinho();
            AtualizarTotalCarrinho();
            AtualizarVisibilidadeCamposDinheiro();
        }
        private void AbrirOuMostrarFormBalcao()
        {
            if (formBalcaoInstance == null || formBalcaoInstance.IsDisposed)
            {
                formBalcaoInstance = new FormBalcao();
                formBalcaoInstance.Show();
            }
            else
            {
                if (!formBalcaoInstance.Visible)
                {
                    formBalcaoInstance.Show();
                }
                formBalcaoInstance.BringToFront();
                formBalcaoInstance.Activate();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto da lista para adicionar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Produto produtoSelecionadoDaLista = (Produto)listBox1.SelectedItem;

            int quantidadeDesejada = (int)numQuantity.Value;

            if (quantidadeDesejada <= 0)
            {
                MessageBox.Show("A quantidade para adicionar deve ser maior que zero.", "Quantidade Inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numQuantity.Value = 1;
                numQuantity.Focus();
                return;
            }

            ItemCarrinho? itemParaSelecionarNoCarrinho = null;

            if (produtoSelecionadoDaLista.QuantidadeEmEstoque <= 0)
            {
                MessageBox.Show($"Desculpe, '{produtoSelecionadoDaLista.Nome}' est� completamente esgotado.", "Produto Esgotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numQuantity.Value = 1;
                return;
            }

            ItemCarrinho? itemExistenteNoCarrinho = carrinhoItens.FirstOrDefault(item => item.Produto.Id == produtoSelecionadoDaLista.Id);
            int quantidadeJaNoCarrinho = itemExistenteNoCarrinho?.Quantidade ?? 0;

            int espacoDisponivelNoEstoqueParaAdicionar = produtoSelecionadoDaLista.QuantidadeEmEstoque - quantidadeJaNoCarrinho;

            if (espacoDisponivelNoEstoqueParaAdicionar <= 0 && itemExistenteNoCarrinho != null)
            {
                MessageBox.Show($"Voc� j� adicionou todo o estoque dispon�vel de '{produtoSelecionadoDaLista.Nome}' ({produtoSelecionadoDaLista.QuantidadeEmEstoque} unidades) ao carrinho.",
                                "Estoque M�ximo no Carrinho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numQuantity.Value = 1;
                itemParaSelecionarNoCarrinho = itemExistenteNoCarrinho;
            }
            else if (espacoDisponivelNoEstoqueParaAdicionar <= 0 && itemExistenteNoCarrinho == null)
            {
                MessageBox.Show($"Desculpe, '{produtoSelecionadoDaLista.Nome}' est� esgotado.", "Produto Esgotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numQuantity.Value = 1;
            }
            else
            {
                int quantidadeRealAdicionada = Math.Min(quantidadeDesejada, espacoDisponivelNoEstoqueParaAdicionar);

                if (quantidadeRealAdicionada <= 0)
                {
                    MessageBox.Show($"N�o foi poss�vel adicionar mais unidades de '{produtoSelecionadoDaLista.Nome}'. Verifique o estoque e a quantidade desejada.",
                               "N�o Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (quantidadeRealAdicionada < quantidadeDesejada)
                    {
                        MessageBox.Show($"Apenas {quantidadeRealAdicionada} unidade(s) de '{produtoSelecionadoDaLista.Nome}' foram adicionadas devido ao estoque limitado.\n" +
                                        $"(Voc� pediu {quantidadeDesejada}, mas apenas {espacoDisponivelNoEstoqueParaAdicionar} unidade(s) extra(s) estava(m) dispon�vel(is) para adicionar ao carrinho).",
                                        "Quantidade Ajustada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (itemExistenteNoCarrinho != null)
                    {
                        itemExistenteNoCarrinho.IncrementarQuantidade(quantidadeRealAdicionada);
                        itemParaSelecionarNoCarrinho = itemExistenteNoCarrinho;
                    }
                    else
                    {
                        ItemCarrinho novoItem = new ItemCarrinho(produtoSelecionadoDaLista, quantidadeRealAdicionada);
                        carrinhoItens.Add(novoItem);
                        itemParaSelecionarNoCarrinho = novoItem;
                    }
                }
            }

            AtualizarDisplayCarrinho();
            AtualizarTotalCarrinho();
            if (itemParaSelecionarNoCarrinho != null)
            {
                SelecionarItemNoCarrinho(itemParaSelecionarNoCarrinho);
            }

            numQuantity.Value = 1;
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
                MessageBox.Show("O carrinho est� vazio. Adicione itens antes de finalizar a compra.", "Carrinho Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            decimal valorPagoPeloCliente = 0m;
            decimal trocoCalculado = 0m;

            if (rbCash.Checked)
            {
                formaPagamentoSelecionada = "Dinheiro";
                if (!decimal.TryParse(txtPaidValue.Text, out valorPagoPeloCliente) || valorPagoPeloCliente <= 0)
                {
                    MessageBox.Show("Por favor, insira um valor pago v�lido.", "Valor Inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaidValue.Focus();
                    return;
                }

                if (valorPagoPeloCliente < valorTotalCompra)
                {
                    MessageBox.Show($"O valor pago (R$ {valorPagoPeloCliente:F2}) � insuficiente para cobrir o total da compra (R$ {valorTotalCompra:F2}).", "Valor Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaidValue.Focus();
                    return;
                }
                trocoCalculado = valorPagoPeloCliente - valorTotalCompra;
                lblChange.Text = $"Troco: R$ {trocoCalculado:F2}";
            }
            else if (rbDebit.Checked)
            {
                formaPagamentoSelecionada = "Cart�o de D�bito";
                valorPagoPeloCliente = valorTotalCompra;
                trocoCalculado = 0;
            }
            else if (rbCredit.Checked)
            {
                formaPagamentoSelecionada = "Cart�o de Cr�dito";
                valorPagoPeloCliente = valorTotalCompra;
                trocoCalculado = 0;
            }
            else if (rbPix.Checked)
            {
                formaPagamentoSelecionada = "PIX";
                valorPagoPeloCliente = valorTotalCompra;
                trocoCalculado = 0;
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
                        MessageBox.Show($"Erro de estoque inconsistente para {produtoOriginalNaLista.Nome}. Opera��o abortada.", "Erro Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Erro cr�tico: Produto '{itemVendido.Produto.Nome}' do carrinho n�o encontrado. Opera��o abortada.", "Erro Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            listBox1.BeginUpdate();
            var produtosParaReexibir = new List<Produto>();
            foreach (Produto prod in listBox1.Items) { produtosParaReexibir.Add(prod); }
            listBox1.Items.Clear();
            foreach (Produto prod in produtosParaReexibir) { listBox1.Items.Add(prod); }
            listBox1.EndUpdate();


            List<ItemCarrinho> itensDoPedido = new List<ItemCarrinho>();
            foreach (var itemOriginalDoCarrinho in carrinhoItens)
            {
                itensDoPedido.Add(new ItemCarrinho(itemOriginalDoCarrinho.Produto, itemOriginalDoCarrinho.Quantidade));
            }

            Pedido novoPedido = new Pedido(
                dataHoraDoPedido,
                nomeDoCliente,
                itensDoPedido,
                formaPagamentoSelecionada,
                valorPagoPeloCliente,
                trocoCalculado
            );

            GerenciadorPedidos.AdicionarPedido(novoPedido);
            string extratoParaCliente = novoPedido.GerarExtratoCompleto();
            string detalhesPagamentoParaMensagem = "";
            if (novoPedido.FormaPagamento == "Dinheiro")
            {
                detalhesPagamentoParaMensagem = $"\nForma de Pagamento: {novoPedido.FormaPagamento}\nValor Pago: R$ {novoPedido.ValorPago:F2}\nTroco: R$ {novoPedido.Troco:F2}";
            }
            else
            {
                detalhesPagamentoParaMensagem = $"\nForma de Pagamento: {novoPedido.FormaPagamento}";
            }

            string resumoPedido = $"Pedido N� {novoPedido.ID} Finalizado!\n\n" +
                                  $"Cliente: {novoPedido.NomeCliente}\n" +
                                  $"Data/Hora: {novoPedido.DataHoraPedido:dd/MM/yyyy HH:mm:ss}\n" +
                                  $"Valor Total: R$ {novoPedido.ValorTotal:F2}" +
                                  $"{detalhesPagamentoParaMensagem}\n\n" +
                                  $"Obrigado!";
            MessageBox.Show(resumoPedido, "Compra Conclu�da", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string mensagemFinal = $"Pedido Registrado com Sucesso!\n\n{extratoParaCliente}\nObrigado!";
            MessageBox.Show(mensagemFinal, "Compra Conclu�da", MessageBoxButtons.OK, MessageBoxIcon.Information);

            carrinhoItens.Clear();
            AtualizarDisplayCarrinho();
            AtualizarTotalCarrinho();

            txtClientName.Clear();
            txtPaidValue.Clear();
            lblChange.Text = "Troco: R$ 0,00";
            numQuantity.Value = 1;
            rbCash.Checked = true;
            AtualizarVisibilidadeCamposDinheiro();
            AbrirOuMostrarFormBalcao();
        }

        private void AtualizarVisibilidadeCamposDinheiro()
        {
            bool pagamentoEmDinheiro = rbCash.Checked;
            lblPaidValue.Visible = pagamentoEmDinheiro;
            txtPaidValue.Visible = pagamentoEmDinheiro;
            lblChange.Visible = pagamentoEmDinheiro;
            pictureBox7.Visible = pagamentoEmDinheiro;

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