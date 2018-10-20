using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Business.Arguments.Usuario
{
    public class ResponseUsuarioCon
    {
        public string Nome { get; set; }

        public static explicit operator ResponseUsuarioCon(string entidade)
        {
            return new ResponseUsuarioCon
            {
                Nome = entidade
            };
        }
    }
}
