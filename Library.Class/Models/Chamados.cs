using Library.Class.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class.Models
{
    [Table("TBL_CHAMADOS")]
    class Chamados
    {
        [Key]
        public int CodigoChamado { get; private set; }

        public int CodigoCliente { get; private set; }

        public int CodigoDepartamento { get; private set; }

        public int CodigoProduto { get; private set; }

        public int CodigoUsuario { get; private set; }

        public string Descricao { get; private set; }

        public int CodigoTipoChamado { get; private set; }
        //no diagrama de classes está somente TipoChamado

        public Chamados(int CodigoChamado, int CodigoCliente, int CodigoDepartamento, int CodigoProduto, int CodigoUsuario,
            string Descricao, int CodigoTipoChamado)

        {
            this.CodigoChamado = CodigoChamado;
            this.CodigoCliente = CodigoCliente;
            this.CodigoDepartamento = CodigoDepartamento;
            this.CodigoProduto = CodigoProduto;
            this.CodigoUsuario = CodigoUsuario;
            this.Descricao = Descricao;
            this.CodigoTipoChamado = CodigoTipoChamado;

        }
    }
}
