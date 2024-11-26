using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prot_tipo___Vortex.Models
{
    public class Atendimento
    {
        public int IdAtendimento { get; set; }
        public int IdPedido { get; set; }
        public int IdSecretaria { get; set; }
        public DateTime DataAtendimento { get; set; }
        public string Observacao { get; set; }
    }
}
