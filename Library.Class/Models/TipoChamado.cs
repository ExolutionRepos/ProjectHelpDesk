using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
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


        public TipoChamados(string descricao, string nome, string sla)
        {
            this.Descricao = descricao;
            this.Nome = nome;
            this.SLA = sla;

            //Chamado = new HashSet<Chamados>();
            BaseConhecimento = new HashSet<BaseConhecimento>();

            Validar();
        }

        public TipoChamados AlterarTipoChamados(string descricao, string nome, string sla)
        {
            this.Descricao = descricao;
            this.Nome = nome;
            this.SLA = sla;

            //Chamado = new HashSet<Chamados>();
            BaseConhecimento = new HashSet<BaseConhecimento>();

            Validar();

            return this;
        }

        private void Validar()
        {
            new AddNotifications<TipoChamados>(this)
                .IfNullOrEmpty(Descricao, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Descricao"))
                .IfNullOrEmpty(Nome, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Tipo"))
                .IfNullOrEmpty(SLA, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("SLA"));
        }

        protected TipoChamados()
        {
            Chamado = new HashSet<Chamados>();
            BaseConhecimento = new HashSet<BaseConhecimento>();
        }

    }
}
