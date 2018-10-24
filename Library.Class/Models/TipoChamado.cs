using prmToolkit.NotificationPattern;
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
    public class TipoChamado : Notifiable
    {
        [Key]
        public int CodigoTipoChamado { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public string SLA { get; private set; }

        public virtual BaseConhecimento BaseConhecimento { get; private set; }

        public TipoChamado(int codigotipochamado, string descricao, string nome, string sla)
        {
            this.CodigoTipoChamado = codigotipochamado;
            this.Descricao = descricao;
            this.Nome = nome;
            this.SLA = sla;
        }

    }
}
