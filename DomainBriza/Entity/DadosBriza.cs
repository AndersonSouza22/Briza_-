using System;
using System.Collections.Generic;
using System.Text;

namespace DomainBriza
{
   public class DadosBriza
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DataCadastro { get; set; }
    }
}
