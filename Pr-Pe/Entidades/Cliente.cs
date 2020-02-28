using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoPedido.Entidades
{
    class Cliente
    {
        public string NomeCliente { get; set; }
        public int Telefone { get; set;  }
        public string Email { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nomeCliente, int telefone, string email)
        {
            NomeCliente = nomeCliente;
            Telefone = telefone;
            Email = email;
        }
    }
}
