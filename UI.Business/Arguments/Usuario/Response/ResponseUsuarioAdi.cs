using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Class.Class;

namespace UI.Business.Arguments.Usuario
{
    public class ResponseUsuarioAdi 
    {
        public int CodigoUsuario { get; set; }

        public string Nome { get; set; }

        public static explicit operator ResponseUsuarioAdi(Usuarios entidade)
        {
            return new ResponseUsuarioAdi()
            {
                CodigoUsuario = entidade.CodigoUsuario,
                Nome = entidade.Nome
            };
        }
    }
}
