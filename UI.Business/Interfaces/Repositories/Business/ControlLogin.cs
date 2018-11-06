using Library.Class.Models;
using UI.Business.Interfaces.Services;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlLogin
    {
        private readonly BaseService<Usuarios> _RepositoryUsuario;
        private readonly BaseService<TipoUsuarios> _RepositoryTipoUsuario;

        public ControlLogin()
        {
            _RepositoryUsuario = new BaseService<Usuarios>();
            _RepositoryTipoUsuario = new BaseService<TipoUsuarios>();
        }

        //public BaseReturn CadastrarLogin()
        //{

        //}
    }
}
