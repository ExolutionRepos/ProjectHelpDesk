using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class.Models
{
    [Table("TBL_TIPOUSUARIO")]

    class Sexo
    {
        [Key]
        public int CodigoTipoUsuario { get; private set; }

        public string Descricao { get; private set; }

        public string Nome { get; private set; }



        public Sexo(int CodigoTipoUsuario, string Descricao, string Nome)
        {
            this.CodigoTipoUsuario = CodigoTipoUsuario;
            this.Descricao = Descricao;
            this.Nome = Nome;
        }

    }
}
