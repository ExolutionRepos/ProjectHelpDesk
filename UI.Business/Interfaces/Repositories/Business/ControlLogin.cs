using Library.Class.Models;
using prmToolkit.NotificationPattern.Extensions;
using System.Linq;
using UI.Business.Interfaces.Services;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlLogin
    {
        private readonly BaseService<Usuarios> _RepositoryUsuario;
        private readonly BaseService<Perfis> _RepositoryPerfi;
        private readonly BaseService<Logins> _RepositoryLogin;

        public ControlLogin()
        {
            _RepositoryUsuario = new BaseService<Usuarios>();
            _RepositoryPerfi = new BaseService<Perfis>();
            _RepositoryLogin = new BaseService<Logins>();
        }

        public BaseReturn CadastrarLogin(int codigousuario, string login, string senha, string senhaantiga, int codigoperfil)
        {

            if(PesquisarLogin(login).FirstOrDefault() != null)
            {
                return new BaseReturn("Login", Library.Class.Resources.Message.JA_EXISTE_UM_X0_CHAMADO_X1.ToFormat("Login",login), false);
            }

            Usuarios DadosUsuarios = _RepositoryUsuario.Find(codigousuario);

            if (DadosUsuarios.IsInvalid())
            {
                return new BaseReturn(DadosUsuarios.Notifications.FirstOrDefault().Property, DadosUsuarios.Notifications.FirstOrDefault().Message, false);
            }
            
            Logins DadosLogin = new Logins(login, senha, senhaantiga);

            if (DadosLogin.IsInvalid())
            {
                return new BaseReturn(DadosLogin.Notifications.FirstOrDefault().Property, DadosLogin.Notifications.FirstOrDefault().Message, false);
            }
            
            Perfis DadosPerfis = _RepositoryPerfi.Find(codigoperfil);
            
            DadosPerfis.Login.Add(DadosLogin);

            _RepositoryPerfi.Edit(DadosPerfis);


            DadosUsuarios.AlterarUsuarios(DadosLogin);

            _RepositoryUsuario.Edit(DadosUsuarios);

            return new BaseReturn("Login", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

        public Logins Pesquisar(int id)
        {
            return _RepositoryLogin.Find(id);
        }


        public IQueryable<Logins> PesquisarLogin(string login)
        {
            var retorno = _RepositoryLogin.List()
                .Where(query => query.Login.Contains(login));

            return retorno;
        }

        public IQueryable<Logins> PesquisarLogin()
        {
            var retorno = _RepositoryLogin.List();

            return retorno;
        }

        public Logins Autenticar(string login, string senha)
        {
            var retorno = PesquisarLogin()
                .Where(y => y.Login == login
                && y.Senha == senha).FirstOrDefault<Logins>();
            
            return retorno;
        }

        public BaseReturn AlterarLogin(int codigologin, string login, string senha, int codigoperfil)
        {

            Logins Dadoslogin = Pesquisar(codigologin).AlterarLogin(login, senha, codigoperfil);

            if (Dadoslogin.IsInvalid())
            {
                return new BaseReturn(Dadoslogin.Notifications.FirstOrDefault().Property, Dadoslogin.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryLogin.Edit(Dadoslogin);

            return new BaseReturn("Login", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

    }
}
