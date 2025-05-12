using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina1
{
    public class ItemCarrinho
    {
        public Produto Produto { get; private set; }
        public int Quantidade { get; set; }         

        public ItemCarrinho(Produto produto, int quantidade = 1)
        {
            if (produto == null)
                throw new ArgumentNullException(nameof(produto));
            if (quantidade <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantidade), "Quantidade deve ser positiva.");

            Produto = produto;
            Quantidade = quantidade;
        }

        public decimal PrecoTotal
        {
            get { return Produto.Preco * Quantidade; }
        }

        public override string ToString()
        {
            return $"{Quantidade}x {Produto.Nome} - R$ {PrecoTotal:F2}";
        }

        public void IncrementarQuantidade(int valor = 1)
        {
            Quantidade += valor;
        }

        public bool DecrementarQuantidade(int valor = 1)
        {
            if (Quantidade > valor)
            {
                Quantidade -= valor;
                return true; 
            }
            else if (Quantidade == valor)
            {
                Quantidade = 0; 
                return false; 
            }
            else
            {
                
                return false;
            }
        }
    }
}