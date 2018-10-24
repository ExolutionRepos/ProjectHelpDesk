using Library.Class.Models;
using System.Collections.Generic;
using UI.Business.Arguments;
using UI.Business.Arguments.Usuario;
using UI.Business.Arguments.Usuario.Request;
using UI.Business.Arguments.Usuario.Response;

namespace UI.Business.Interfaces.Repositories
{
    interface IRepositoryUsuario
    {
        ResponseUsuarioAdi AdicionarUsuario(RequestUsuarioAdi Request);

        ResponseBase AlterarUsuario(RequestUsuarioAlt Request);

        ResponseUsuarioCon ConsultarUsuario(RequestUsuarioCon Request);

        ResponseUsuarioLis ConsultarListaUsuario(RequestUsuarioLis Request);

        ResponseBase DeletarUsuario(RequestUsuarioDel Request);

        List<Usuarios> UConsultarUsuario(Usuarios Request);

        List<Usuarios> UConsultarUsuario(RequestUsuarioCon Request);
    }
}
