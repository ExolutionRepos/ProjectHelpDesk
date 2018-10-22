using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class.Models
{
    [Table("TBL_SEXO")]

    class Sexos
    {
        [Key]
        public int CodigoSexo { get; private set; }

        public string Sexo { get; private set; }



        public Sexos(int CodigoTipoUsuario, string Descricao, string Nome)
        {
            this.CodigoSexo = CodigoSexo;
            this.Sexo = Sexo;

        }

    }
}
