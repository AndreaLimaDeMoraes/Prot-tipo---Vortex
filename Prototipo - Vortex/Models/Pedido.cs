using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prot_tipo___Vortex.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdAluno { get; set; }
        public int IdDocumento { get; set; }
        public DateTime DataPedido { get; set; }
        public string Status { get; set; }
    }
}
