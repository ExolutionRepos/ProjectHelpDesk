using prmToolkit.NotificationPattern;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Models
{

    [Table("TBL_TIPOCHAMADO")]
    public class TipoChamados : Notifiable
    {
        [Key]
        public int CodigoTipoChamado { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public string SLA { get; private set; }

        public ICollection<Chamados> Chamado { get; private set; }

        public ICollection<BaseConhecimento> BaseConhecimento { get; private set; }


        public TipoChamados(int codigotipochamado, string descricao, string nome, string sla)
        {
            this.CodigoTipoChamado = codigotipochamado;
            this.Descricao = descricao;
            this.Nome = nome;
            this.SLA = sla;

            Chamado = new HashSet<Chamados>();
            BaseConhecimento = new HashSet<BaseConhecimento>();
        }

        protected TipoChamados()
        {
            Chamado = new HashSet<Chamados>();
            BaseConhecimento = new HashSet<BaseConhecimento>();
        }

    }
}
