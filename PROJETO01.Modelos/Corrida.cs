using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO01.Modelos
{
  public  class Corrida
    {
        public int MotoristaId{ get; set; }

        public int IdSolicitacao{ get; set; }

        public int PessoaId { get; set; }

        public int CidadeId { get; set; }

        public string  Avaliacao { get; set; }
    }
}
