using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class.Models
{
    [Table("TBL_USUARIOCHAMADO")]
    class UsuarioChamado
    {
        [Key]
        public int CodigoUsuarioChamado { get; private set; }

        public int Cliente { get; private set; }

        public string Usuario { get; private set; }

        public UsuarioChamado(int CodigoTipoUsuario, int Cliente, string Usuario)
        {
            this.CodigoUsuarioChamado = CodigoUsuarioChamado;
            this.Cliente = Cliente;
            this.Usuario = Usuario;


        }
    }
}
