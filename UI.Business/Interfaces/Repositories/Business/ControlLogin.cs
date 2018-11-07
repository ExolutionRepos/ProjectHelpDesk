using Library.Class.Models;
using UI.Business.Interfaces.Services;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlLogin
    {
        private readonly BaseService<Usuarios> _RepositoryUsuario;
        private readonly BaseService<TipoUsuarios> _RepositoryTipoUsuario;
        private readonly BaseService<Logins> _RepositoryLogin;

        public ControlLogin()
        {
            _RepositoryUsuario = new BaseService<Usuarios>();
            _RepositoryTipoUsuario = new BaseService<TipoUsuarios>();
            _RepositoryLogin = new BaseService<Logins>();
        }

        //public BaseReturn CadastrarLogin()
        //{

        //}

        public Logins Pesquisar(int id)
        {
            return _RepositoryLogin.Find(id);
        }
    }
}
