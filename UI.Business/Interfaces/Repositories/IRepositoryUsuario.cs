using Library.Class.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Business.Arguments.Usuario;
using UI.Business.Repositories;

namespace UI.Business.Interfaces.Repositories
{
    interface IRepositoryUsuario
    {
        ResponseUsuario AdicionarUsuario(RequestUsuario Request);

        ResponseUsuario AlterarUsuario(RequestUsuario Request);
    }
}
