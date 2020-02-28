using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoPedido.Entidades
{
    class Categoria
    {
        public string NomeCategoria { get; set; }

        public Categoria()
        {

        }

        public Categoria(string nomeCategoria)
        {
            NomeCategoria = nomeCategoria;
        }
    }
}
