using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Class.Enum.EnumStatusChamado;

namespace Library.Class.Models
{
    [Table("TBL_CHAMADOS")]
    public class Chamados : Notifiable
    {
        [Key]
        public int CodigoChamado { get; private set; }

        public string Descricao { get; private set; }

        public string Observacao { get; private set; }

        public int CodigoTipoChamado { get; private set; }
        [Required(ErrorMessage = "Especifique o tipo de problema"), ForeignKey("CodigoTipoChamado")]
        public virtual TipoChamados TipoChamado { get; private set; }

        [Required(ErrorMessage = "Cliente não cadastrado/encontrado")]
        public virtual Usuarios Cliente { get; private set; }
        
        public int CodigoProduto { get; private set; }
        [Required(ErrorMessage = "É necessario informar o produto"),ForeignKey("CodigoProduto")]
        public virtual Produtos Produto { get; private set; }

        public virtual Usuarios Funcionario { get; private set; }

        public virtual Departamentos Departamento { get; private set; }

        public StatusChamado Status { get; private set; }

        protected Chamados(string descricao, string observacao)
        {
            this.Descricao = descricao;
            this.Observacao = observacao;

            new AddNotifications<Chamados>(this)
                .IfNullOrEmpty(x => x.Descricao, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Descricao"));
        }
    }
}
