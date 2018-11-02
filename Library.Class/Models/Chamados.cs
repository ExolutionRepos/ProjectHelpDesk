using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Models
{
    [Table("TBL_CHAMADOS")]
    public class Chamados : Notifiable
    {
        [Key]
        //, Column("CodigoChamado", TypeName = "int")
        public int CodigoChamado { get; private set; }

        //[Column("Descricao", TypeName = "varchar(100)")]
        public string Descricao { get; private set; }

        //[Column("Observacao", TypeName = "varchar(500)")]
        public string Observacao { get; private set; }

        [Required(ErrorMessage = "Especifique o tipo de problema")]
        public virtual TipoChamados TipoChamado { get; private set; }

        [Required(ErrorMessage = "Cliente não cadastrado/encontrado")]
        public virtual Usuarios Cliente { get; private set; }

        [Required(ErrorMessage = "É necessario informar o produto")]
        public virtual Produtos Produto { get; private set; }

        public virtual Usuarios Funcionario { get; private set; }

        public virtual Departamentos Departamento { get; private set; }


        protected Chamados(string descricao, string observacao)
        {
            this.Descricao = descricao;
            this.Observacao = observacao;

            new AddNotifications<Chamados>(this)
                .IfNullOrEmpty(x => x.Descricao, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Descricao"));
        }
    }
}
