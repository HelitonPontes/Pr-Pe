using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoPedido.Entidades
{
    class Produto
    {
        public string NomeProduto { get; set; }
        public Categoria Categoria { get; set; }
        public double Valor { get; set; }

        public Produto()
        {

        }

        public Produto(string nomeProduto, Categoria categoria, double valor)
        {
            NomeProduto = nomeProduto;
            Categoria = categoria;
            Valor = valor;
        }
    }
}
