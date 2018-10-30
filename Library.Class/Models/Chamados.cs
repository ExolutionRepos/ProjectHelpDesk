using prmToolkit.NotificationPattern;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Class.Models
{
    [Table("TBL_CHAMADOS")]
    public class Chamados : Notifiable
    {
        [Key]
        public int CodigoChamado { get; private set; }

        public int CodigoCliente { get; private set; }

        public int CodigoDepartamento { get; private set; }

        public int CodigoProduto { get; private set; }

        public int CodigoUsuario { get; private set; }

        public string Descricao { get; private set; }
        
        [Required]
        public virtual TipoChamados TipoChamado { get; private set; }

        public Chamados(int codigochamado, int codigocliente, int codigodepartamento, int codigoproduto, int codigousuario,
            string descricao, int codigotipochamado)

        {
            this.CodigoChamado = codigochamado;
            this.CodigoCliente = codigocliente;
            this.CodigoDepartamento = codigodepartamento;
            this.CodigoProduto = codigoproduto;
            this.CodigoUsuario = codigousuario;
            this.Descricao = descricao;

        }
    }
}
