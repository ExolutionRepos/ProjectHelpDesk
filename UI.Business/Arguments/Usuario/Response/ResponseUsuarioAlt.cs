using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Class.Class;

namespace UI.Business.Arguments.Usuario
{
    public class ResponseUsuarioAlt 
    {
        
        public string sNome { get; set; }

        public static explicit operator ResponseUsuarioAlt(Usuarios entidade)
        {
            {
                return new ResponseUsuarioAlt()
                {
                    sNome = entidade.Nome
                };
            }
        }
    }
}
