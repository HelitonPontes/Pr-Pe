using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoPedido.Entidades
{
    class ItemProduto
    {
        public int Quantidade { get; set; }
        public double ValorP { get; set; }
        public double ValorSV { get; set; }
        public Produto Produto { get; set; }
     

        public ItemProduto()
        {

        }

        public ItemProduto(int quantidade, double valorP, Produto produto)
        {
            Quantidade = quantidade;
            ValorP = valorP;
            Produto = produto;
        }

        public ItemProduto(int quantidade, double valorP, double valorSV, Produto produto)
        {
            Quantidade = quantidade;
            ValorP = valorP;
            ValorSV = valorSV;
            Produto = produto;
        }

        public  double SubValor()
        {
            ValorSV = ValorP * Quantidade ;

            return ValorSV;
        }
        public double VT()
        {
           
            ValorSV = ValorSV++;
            return ValorSV;
        }
    }
}
