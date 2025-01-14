using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralLabSolutions.Domain.Entities.Base;

namespace GeneralLabSolutions.Domain.Entities
{
    public class PessoaTelefone : EntityBase
    {
        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public Guid TelefoneId { get; set; }
        public Telefone Telefone { get; set; }
    }

}
