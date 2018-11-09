using Library.Class.Models;
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
            Usuarios DadosUsuarios = _RepositoryUsuario.Find(codigousuario);

            if (DadosUsuarios.IsInvalid())
            {
                return new BaseReturn(DadosUsuarios.Notifications.FirstOrDefault().Property, DadosUsuarios.Notifications.FirstOrDefault().Message, false);
            }
            
            Logins DadosLogin = new Logins(login, senha, senhaantiga);
            
            DadosUsuarios.AlterarUsuarios(DadosLogin);
            
            Perfis DadosPerfis = _RepositoryPerfi.Find(codigoperfil);

            DadosPerfis.Login.Add(DadosLogin);

            _RepositoryPerfi.Edit(DadosPerfis);

            return new BaseReturn("Usuario", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

        public Logins Pesquisar(int id)
        {
            return _RepositoryLogin.Find(id);
        }
    }
}
