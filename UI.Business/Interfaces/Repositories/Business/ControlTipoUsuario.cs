using Library.Class.Models;
using System.Linq;
using UI.Business.Interfaces.Services;
using prmToolkit.NotificationPattern.Extensions;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlTipoUsuario
    {
        private readonly BaseService<TipoUsuarios> _RepositoryUsuario;

        public ControlTipoUsuario()
        {
            _RepositoryUsuario = new BaseService<TipoUsuarios>();
        }

        public TipoUsuarios Pesquisar(int id)
        {
            return _RepositoryUsuario.Find(id);
        }


        public IQueryable<TipoUsuarios> PesquisarTipoUsuario(string nome)
        {
            var retorno = _RepositoryUsuario.List()
                .Where(query => query.Nome.Contains(nome));

            return retorno;
        }

        public IQueryable<TipoUsuarios> PesquisarTipoUsuario()
        {
            var retorno = _RepositoryUsuario.List();

            return retorno;
        }

        public BaseReturn CadastrarTipoUsuario(string descricao, string nome)
        {
            TipoUsuarios DadosTipoUsuarios = new TipoUsuarios(descricao, nome);

            if (DadosTipoUsuarios.IsInvalid())
            {
                return new BaseReturn(DadosTipoUsuarios.Notifications.FirstOrDefault().Property, DadosTipoUsuarios.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryUsuario.Add(DadosTipoUsuarios);

            return new BaseReturn("Tipo Usuario", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

        public BaseReturn AlterarTipoUsuario(int codigotipo, string nome, string descricao)
        {
            var DadosTipoUsuarios = Pesquisar(codigotipo);

            if(DadosTipoUsuarios == null)
            {
                return new BaseReturn("Tipo Usuario", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, true);
            }

            DadosTipoUsuarios = DadosTipoUsuarios.AlterarTipoUsuarios(descricao, nome);

            if (DadosTipoUsuarios.IsInvalid())
            {
                return new BaseReturn(DadosTipoUsuarios.Notifications.FirstOrDefault().Property, DadosTipoUsuarios.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryUsuario.Edit(DadosTipoUsuarios);

            return new BaseReturn("Tipo Usuario", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }
    }
}
