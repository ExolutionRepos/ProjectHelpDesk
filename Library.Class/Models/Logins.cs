using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class.Models
{
    [Table("TBL_LOGINS")]
    class Logins
    {

        [Key]
        public int CodigoLogin { get; private set; }

        public int CodigoUsuario { get; private set; }

        public string Senha { get; private set; }

        public string SenhaAntiga { get; private set; }


        public Logins(int CodigoLogin, int CodigoUsuario, string Senha, string SenhaAntiga)
        {
            this.CodigoLogin = CodigoLogin;
            this.CodigoUsuario = CodigoUsuario;
            this.Senha = Senha;
            this.SenhaAntiga = SenhaAntiga;

        }

    }
}


