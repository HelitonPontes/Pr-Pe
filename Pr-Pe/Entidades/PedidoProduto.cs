using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdutoPedido.Entidades;

namespace ProdutoPedido.Entidades
{
    class PedidoProduto
    {
        public DateTime Data = DateTime.Now;
        public EstadoPedido EstadoPedido { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemProduto> Lista { get; set; } = new List<ItemProduto>();
      

        
       public PedidoProduto()
        {


        }

        public PedidoProduto(DateTime data, EstadoPedido estadoPedido, Cliente cliente)
        {
            Data = data;
            EstadoPedido = estadoPedido;
            Cliente = cliente;
        }

        public void AddItem(ItemProduto itemProduto)
        {
            Lista.Add(itemProduto);
        }

        public void RemoveItem(ItemProduto itemProduto)
        {
            Lista.Remove(itemProduto);
        }
        public double ValorTotal()
        {
            double soma = 0.0 ;
            soma = soma++;

            
            
            foreach (ItemProduto item in Lista)
            {
                 soma +=item.ValorSV;

            }
            return soma;
        }


        public PedidoProduto(List<ItemProduto> lista)
        {
            Lista = lista;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Data>: " +  Data  );
            sb.AppendLine("Estado>: " +EstadoPedido.Estado);    
            sb.AppendLine("Cliente>: " + Cliente.NomeCliente);
            sb.AppendLine("Cliente Telefone>: " + Cliente.Telefone);
            sb.AppendLine("Cliente Email>: " + Cliente.Email);
            sb.AppendLine("Itens>: "+ Lista);

            foreach (ItemProduto itemProduto  in Lista)
            {
                sb.AppendLine(itemProduto.ToString());
            }


            

            return sb.ToString();
        }

    }
}
