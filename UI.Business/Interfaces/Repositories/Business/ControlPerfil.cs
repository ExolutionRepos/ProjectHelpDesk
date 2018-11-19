using Library.Class.Models;
using prmToolkit.NotificationPattern.Extensions;
using System.Linq;
using UI.Business.Interfaces.Services;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlPerfil
    {
        private readonly BaseService<Perfis> _RepositoryPerfil;

        public ControlPerfil()
        {
            _RepositoryPerfil = new BaseService<Perfis>();
        }

        public Perfis Pesquisar(int id)
        {
            return _RepositoryPerfil.Find(id);
        }


        public IQueryable<Perfis> PesquisarPerfil(string nome)
        {
            var retorno = _RepositoryPerfil.List()
                .Where(query => query.Nome.Contains(nome));

            return retorno;
        }

        public IQueryable<Perfis> PesquisarPerfil()
        {
            var retorno = _RepositoryPerfil.List();

            return retorno;
        }

        public BaseReturn CadastrarPerfil(string nome, string descricao)
        {
            var Dados = PesquisarPerfil()
              .Where(y => y.Nome == nome).FirstOrDefault();

            if (Dados != null)
            {
                return new BaseReturn("Perfil", Library.Class.Resources.Message.JA_EXISTE_UMA_X0_CHAMADA_X1.ToFormat("Nome", Dados.Nome.ToString()), true);
            }


            Perfis DadosPerfil = new Perfis(descricao, nome);

            if (DadosPerfil.IsInvalid())
            {
                return new BaseReturn(DadosPerfil.Notifications.FirstOrDefault().Property, DadosPerfil.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryPerfil.Add(DadosPerfil);

            return new BaseReturn("Perfil", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

        public BaseReturn AlterarPerfil(int codigotipo, string nome, string descricao)
        {
            var DadosPerfil = Pesquisar(codigotipo);

            if (DadosPerfil == null)
            {
                return new BaseReturn("Perfil", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, true);
            }

            DadosPerfil = DadosPerfil.AlterarPerfil(descricao, nome);

            if (DadosPerfil.IsInvalid())
            {
                return new BaseReturn(DadosPerfil.Notifications.FirstOrDefault().Property, DadosPerfil.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryPerfil.Edit(DadosPerfil);

            return new BaseReturn("Perfil", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }
    }
}
