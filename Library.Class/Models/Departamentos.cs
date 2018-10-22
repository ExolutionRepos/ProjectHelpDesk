using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class.Models
{
    [Table("TBL_DEPARTAMENTOS")]
    class Departamentos
    {
        [Key]
        public int CodigoDepartamento { get; private set; }

        public int CodigoDepartamentoUsuario { get; private set; }
        //no diagrama está somente DepartamentoUsuario

        public string Descricao { get; private set; }

        public string Endereco { get; private set; }

        public string Nome { get; private set; }

        public Departamentos(int CodigoDepartamento, int CodigoDepartamentoUsuario, string Descricao, string Endereco,
            string Nome)
        {
            this.CodigoDepartamento = CodigoDepartamento;
            this.CodigoDepartamentoUsuario = CodigoDepartamentoUsuario;
            this.Descricao = Descricao;
            this.Endereco = Endereco;
            this.Nome = Nome;

        }
    }
}
