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
                Produto produtoSelecionado = (Produto)listBox1.SelectedItem;
                ItemCarrinho itemParaSelecionar = null;

                ItemCarrinho? itemExistente = carrinhoItens.FirstOrDefault(item => item.Produto.Id == produtoSelecionado.Id);

                if (itemExistente != null)
                {
                    itemExistente.IncrementarQuantidade();
                    itemParaSelecionar = itemExistente;
                }
                else
                {
                    ItemCarrinho novoItem = new ItemCarrinho(produtoSelecionado, 1);
                    carrinhoItens.Add(novoItem);
                    itemParaSelecionar = novoItem;
                }

                AtualizarDisplayCarrinho();
                AtualizarTotalCarrinho();
                SelecionarItemNoCarrinho(itemParaSelecionar);
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
                ItemCarrinho itemParaSelecionarAposRemocao = null;

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


            int totalUnidades = 0;
            foreach (ItemCarrinho item in carrinhoItens)
            {
                totalUnidades += item.Quantidade;
            }


            string resumoPedido = $"Pedido Finalizado com Sucesso!\n\n" +
                                  $"Total de Produtos Diferentes: {carrinhoItens.Count}\n" +
                                  $"Total de Unidades: {totalUnidades}\n" +
                                  $"Valor Total: {txtTotal.Text.Replace("Total: ", "")}\n\n" +
                                  $"Obrigado pela sua compra!";

            MessageBox.Show(resumoPedido, "Compra Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);


            carrinhoItens.Clear();
            AtualizarDisplayCarrinho();
            AtualizarTotalCarrinho();
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
    }
}