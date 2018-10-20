using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Business.Arguments.Usuario
{
    public class RequestUsuarioCon
    {
        public int CodigoUsuario { get; set; }

        public static explicit operator RequestUsuarioCon(int codigousuario)
        {
            return new RequestUsuarioCon
            {
                CodigoUsuario = codigousuario
            };
        }
    }
}
