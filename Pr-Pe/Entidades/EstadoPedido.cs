using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoPedido.Entidades
{
    class EstadoPedido
    {
        public string Estado { get; set; }
        public string Aguardando = "AguandandoAprovação";
        public string Aprovado = "Aprovado";
        public string Instalado = "Instalando";
        public string Finalizado = "Finalizado";

        public EstadoPedido()
        {

        }

        public EstadoPedido(string estado)
        {
            Estado = estado;
        }

        public   void EP ()
        {
            Estado = Aguardando;
        }
    }
}
