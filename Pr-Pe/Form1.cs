using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProdutoPedido.Entidades;


namespace Pr_Pe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }


        public void btnProcessar_Click(object sender, EventArgs e)
        {
            string cliente1 = txtNome.Text;
            int telefone = int.Parse(txtTelefone.Text);
            string email = txtEmail.Text;

            Cliente cliente = new Cliente(cliente1, telefone, email);

            lblNome.Text = cliente.NomeCliente;
            lblTelefone.Text = Convert.ToString(cliente.Telefone);
            lblEmail.Text = cliente.Email;
           

            


            EstadoPedido estadoPedido = new EstadoPedido();

            PedidoProduto pedidoProduto = new PedidoProduto(DateTime.Now, estadoPedido, cliente);

            

            lblData.Text = Convert.ToString(pedidoProduto.Data);
            lblEstado.Text = pedidoProduto.EstadoPedido.Aguardando;

            /*
            string produtonome = txtProduto.Text;
            string cat = txtCategoria.Text;
            double valor = double.Parse(txtValor.Text);


            Categoria categoria = new Categoria(cat);

            Produto produto = new Produto(produtonome, categoria, valor);

            int quantidade = int.Parse(txtQuantidade.Text);
            double valorP = valor;

            ItemProduto itemProduto = new ItemProduto(quantidade, valorP, produto);

            pedidoProduto.Lista.Add(itemProduto);


            lblProduto.Text = produto.NomeProduto;
            lblQuantidade.Text = Convert.ToString(itemProduto.Quantidade);
            lblCategoria.Text = produto.Categoria.NomeCategoria;
            lblValor.Text = Convert.ToString(produto.Valor);
            //lblData.Text = Convert.ToString(pedidoProduto.Data);
            //lblEstado.Text = pedidoProduto.EstadoPedido.Aguardando;
            lblSubValor.Text = Convert.ToString(itemProduto.SubValor());


    */


        }


        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
           

            string produtonome = txtProduto.Text;
            string cat = txtCategoria.Text;
            double valor = double.Parse(txtValor.Text);



            Categoria categoria = new Categoria(cat);

            Produto produto = new Produto(produtonome, categoria, valor);

            

            int quantidade = int.Parse(txtQuantidade.Text);
            double valorP = valor;

            ItemProduto itemProduto = new ItemProduto(quantidade, valorP, produto);

         
            PedidoProduto pedidoProduto = new PedidoProduto();


            pedidoProduto.AddItem(itemProduto);


            lblProduto.Text = itemProduto.Produto.NomeProduto;
            lblQuantidade.Text = Convert.ToString(itemProduto.Quantidade);
            lblCategoria.Text = produto.Categoria.NomeCategoria;
            lblValor.Text = Convert.ToString(itemProduto.Produto.Valor);
            //lblData.Text = Convert.ToString(pedidoProduto.Data);
            //lblEstado.Text = pedidoProduto.EstadoPedido.Aguardando;
            lblSubValor.Text = Convert.ToString(itemProduto.SubValor());

            txtProduto.Clear();
            txtQuantidade.Clear();
            txtCategoria.Clear();
            txtValor.Clear();

           
          
            foreach (ItemProduto pr in pedidoProduto.Lista)
            {
                lblProduto.Text = Convert.ToString(pr.Produto.NomeProduto);
                lblQuantidade.Text = Convert.ToString(pr.Quantidade);
                //lblCategoria.Text = Convert.ToString(pr.ca);
                lblValor.Text = Convert.ToString(pr.ValorP);

                 listBox1.Items.Add("Produto: " + pr.Produto.NomeProduto + "  Quant: " + pr.Quantidade
                    + "   Valor>: " + pr.ValorP+"  Valor: "+ pr.SubValor());

                
                lblValorTotal.Text = Convert.ToString(pr.VT());

              
            }
            //lblValorTotal.Text = Convert.ToString(vt);

        }

        private void btnFRMteste_Click(object sender, EventArgs e)
        {

           
        }
    }
}
