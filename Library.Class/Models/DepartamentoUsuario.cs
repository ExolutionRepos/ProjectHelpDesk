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
    [Table("TBL_DEPARTAMENTOUSUARIO")]

    class DepartamentoUsuario
    {
        [Key]
        public int CodigoDepartamentoUsuario { get; private set; }

        public int CodigoDepartamento { get; private set; }

        public int CodigoUsuario { get; private set; }

        public DepartamentoUsuario(int CodigoDepartamentoUsuario, int CodigoDepartamento, int CodigoUsuario)
        {
            this.CodigoDepartamentoUsuario = CodigoDepartamentoUsuario;
            this.CodigoDepartamento = CodigoDepartamento;
            this.CodigoUsuario = CodigoUsuario;

        }

    }
}
