using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class.Models
{

    [Table("TBL_TIPOCHAMADO")]
    class TipoChamado
    {
        [Key]
        public int CodigoTipoChamado { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public string SLA { get; private set; }


        public TipoChamado(int CodigoTipoChamado, string Descricao, string Nome, string SLA)
        {
            this.CodigoTipoChamado = CodigoTipoChamado;
            this.Descricao = Descricao;
            this.Nome = Nome;
            this.SLA = SLA;
        }

    }
}
