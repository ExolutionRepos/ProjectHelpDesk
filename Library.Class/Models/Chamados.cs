using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Class.Enum.EnumChamado;
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
        //[Required(ErrorMessage = "Especifique o tipo de problema"), ForeignKey("CodigoTipoChamado")]
        [ForeignKey("CodigoTipoChamado")]
        public virtual TipoChamados TipoChamado { get; private set; }

        public int CodigoProduto { get; private set; }
        //[Required(ErrorMessage = "É necessario informar o produto"),ForeignKey("CodigoProduto")]
        [ForeignKey("CodigoProduto")]
        public virtual Produtos Produto { get; private set; }

        public int CodigoUsuario_Cliente { get; private set; }
        //[Required(ErrorMessage = "Cliente não cadastrado/encontrado"), ForeignKey("CodigoUsuario_Cliente")]
        [ForeignKey("CodigoUsuario_Cliente")]
        public virtual Usuarios Cliente { get; private set; }

        public int? CodigoUsuario_Funcionario { get; private set; }
        [ForeignKey("CodigoUsuario_Funcionario")]
        public virtual Usuarios Funcionario { get; private set; }

        public int? CodigoDepartamento { get; private set; }
        //[Required(ErrorMessage = "É necessario informar o departamento"), ForeignKey("CodigoDepartamento")]
        [ForeignKey("CodigoDepartamento")]
        public virtual Departamentos Departamento { get; private set; }

        public StatusChamado Status { get; private set; }

        public ChamadoPrioridade Prioridade { get; private set; }

        public DateTime? DataInicio { get; private set; }

        public DateTime? DataFinalizacao { get; private set; }

        public DateTime? DataGarantia { get; private set; }

        public Chamados(string descricao, string observacao, StatusChamado status, ChamadoPrioridade prioridade,
            int codigotipochamado,
            int codigoproduto,
            int codigousuario_cliente,
            int? codigousuario_funcionario,
            int? codigodepartamento, DateTime? datagarantia)
        {
            this.Descricao = descricao;
            this.Observacao = observacao;
            this.Status = status;
            this.Prioridade = prioridade;

            this.CodigoTipoChamado = codigotipochamado;
            this.CodigoProduto = codigoproduto;
            this.CodigoUsuario_Cliente = codigousuario_cliente;
            this.CodigoUsuario_Funcionario = codigousuario_funcionario;
            this.CodigoDepartamento = codigodepartamento;

            this.DataInicio = DateTime.Now;
            this.DataGarantia = datagarantia;

            Validar();
        }

        public Chamados Alterarchamado(string descricao, string observacao, StatusChamado status, ChamadoPrioridade prioridade,
            int codigotipochamado,
            int codigoproduto,
            int codigousuario_cliente,
            int? codigousuario_funcionario,
            int? codigodepartamento, DateTime? datagarantia)
        {
            this.Descricao = descricao;
            this.Observacao = observacao;
            this.Status = status;
            this.Prioridade = prioridade;

            this.CodigoTipoChamado = codigotipochamado;
            this.CodigoProduto = codigoproduto;
            this.CodigoUsuario_Cliente = codigousuario_cliente;
            this.CodigoUsuario_Funcionario = codigousuario_funcionario;
            this.CodigoDepartamento = codigodepartamento;

            this.DataGarantia = datagarantia;

            Validar();

            return this;
        }

        private void Validar()
        {
            new AddNotifications<Chamados>(this)
                .IfNullOrEmpty(x => x.Descricao, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("Descricao"));
        }

        public Chamados AlterarStatusChamado(StatusChamado status)
        {
            this.Status = status;
            return this;
        }

        public Chamados()
        {

        }

        public override string ToString()
        {
            return String.Format("{0}{1}{2}", CodigoDepartamento.ToString().PadLeft(3, '0'), CodigoTipoChamado.ToString().PadLeft(2, '0'), CodigoChamado.ToString().PadLeft(5, '0'));
        }

        public string ToString(string codigodepartamento,string codigotipochamado, string codigochamado)
        {
            return String.Format("{0}{1}{2}", codigodepartamento.ToString().PadLeft(3, '0'), codigotipochamado.ToString().PadLeft(2, '0'), codigochamado.ToString().PadLeft(5, '0'));
        }
    }
}
