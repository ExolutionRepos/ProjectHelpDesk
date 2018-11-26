using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace Library.Class.Models

{
    [Table("TBL_BASECONHECIMENTO")]
    public class BaseConhecimento : Notifiable
    {
        [Key]
        public int CodigoBaseConhecimento { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }

        public string PalavraChave { get; private set; }

        public int CodigoTipoChamado { get; private set; }
        [ForeignKey("CodigoTipoChamado")]
        public virtual TipoChamados TipoChamado { get; private set; }

        public BaseConhecimento( string descricao, string nome,string palavrachave)
        {
           
            this.Descricao = descricao;
            this.Nome = nome;
            this.PalavraChave = palavrachave;

            Validar();
        }

        public BaseConhecimento AlterarBaseConhecimento(string descricao, string nome,
            string palavrachave, int codigotipochamado)
        {
            
            this.Descricao = descricao;
            this.Nome = nome;
            this.PalavraChave = palavrachave;
            this.CodigoBaseConhecimento = codigotipochamado;

            Validar();

            return this;
        }

        private void Validar()
        {
            new AddNotifications<BaseConhecimento>(this)
                .IfNullOrEmpty(this.Descricao, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Descricao"))
                .IfNullOrEmpty(this.Nome, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Nome"));
        }

        protected BaseConhecimento()
        {

        }
    }
}
