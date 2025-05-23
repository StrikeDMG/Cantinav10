using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina1
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public Produto(int id, string nome, decimal preco, int quantidadeEmEstoque)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public override string ToString()
        {
            string displayEstoque;
            if (QuantidadeEmEstoque > 0)
            {
                displayEstoque = $"({QuantidadeEmEstoque})";
            }
            else
            {
                displayEstoque = "(Esgotado)";
            }
            return $"{Nome} {displayEstoque} - R$ {Preco:F2}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Produto other = (Produto)obj;
            return Id == other.Id; 
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode(); 
        }
        
    }
}