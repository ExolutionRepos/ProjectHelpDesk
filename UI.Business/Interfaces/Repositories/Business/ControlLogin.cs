using Library.Class.Models;
using System.Linq;
using UI.Business.Interfaces.Services;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlLogin
    {
        private readonly BaseService<Usuarios> _RepositoryUsuario;
        private readonly BaseService<TipoUsuarios> _RepositoryTipoUsuario;
        private readonly BaseService<Logins> _RepositoryLogins;

        public ControlLogin()
        {
            _RepositoryUsuario = new BaseService<Usuarios>();
            _RepositoryTipoUsuario = new BaseService<TipoUsuarios>();
            _RepositoryLogins = new BaseService<Logins>();
        }


        public BaseReturn CadastrarLogin(string login, string senha, string senhaantiga, Usuarios usuarios)
        {

            Logins DadosLogin = new Logins(login, senha, senhaantiga, usuarios);

            if (DadosLogin.IsInvalid())
            {
                return new BaseReturn(DadosLogin.Notifications.FirstOrDefault().Property, DadosLogin.Notifications.FirstOrDefault().Message, false);
            }

            return new BaseReturn("Logins", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);

            //public BaseReturn CadastrarLogin()
            //{

            //}
        }

        public BaseReturn AlterarLogin(int codigologin, string login, string senha, string senhaantiga, Usuarios usuario)
        {
            Logins DadosLogin = _RepositoryLogins.Find(codigologin);

            return new BaseReturn("Logins", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }


        public IQueryable<Logins> PesquisarUsuario(string login)
        {
            var retorno = _RepositoryLogins.List()
                .Where(query => query.Login.Contains(login));

            return retorno;
        }


        public Logins Pesquisar(int id_login)
        {
            return _RepositoryLogins.Find(id_login);
        }

        public BaseReturn Remover(int id_login)
        {
            _RepositoryLogins.Remove(_RepositoryLogins.Find(id_login));

            return new BaseReturn("Logins", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

    }
}
