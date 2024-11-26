using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prot_tipo___Vortex.Models
{
    public class Documento
    {
        public int IdDocumento { get; set; }
        public int IdAluno { get; set; }
        public string NomeDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
