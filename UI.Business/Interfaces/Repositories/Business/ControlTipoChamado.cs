using Library.Class.Models;
using prmToolkit.NotificationPattern.Extensions;
using System.Linq;
using UI.Business.Interfaces.Services;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlTipoChamado
    {
        private readonly BaseService<TipoChamados> _RepositoryTipoChamado;

        public ControlTipoChamado()
        {
            _RepositoryTipoChamado = new BaseService<TipoChamados>();
        }

        public TipoChamados Pesquisar(int id)
        {
            return _RepositoryTipoChamado.Find(id);
        }


        public IQueryable<TipoChamados> PesquisarTipoChamado(string nome)
        {
            var retorno = _RepositoryTipoChamado.List()
                .Where(query => query.Nome.Contains(nome));

            return retorno;
        }

        public IQueryable<TipoChamados> PesquisarTipoChamado()
        {
            var retorno = _RepositoryTipoChamado.List();

            return retorno;
        }

        public BaseReturn CadastrarTipoChamado(string nome, string descricao, string sla)
        {
            var Dados = PesquisarTipoChamado()
              .Where(y => y.Nome == nome).FirstOrDefault();

            if (Dados != null)
            {
                return new BaseReturn("Tipo de Chamado", Library.Class.Resources.Message.JA_EXISTE_UMA_X0_CHAMADA_X1.ToFormat("Nome", Dados.Nome.ToString()), true);
            }


            TipoChamados DadosTipoChamado = new TipoChamados(descricao, nome, sla);

            if (DadosTipoChamado.IsInvalid())
            {
                return new BaseReturn(DadosTipoChamado.Notifications.FirstOrDefault().Property, DadosTipoChamado.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryTipoChamado.Add(DadosTipoChamado);

            return new BaseReturn("Tipo de Chamado", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

        public BaseReturn AlterarPerfil(int codigotipo, string nome, string descricao, string sla)
        {
            var DadosTipoChamado = Pesquisar(codigotipo);

            if (DadosTipoChamado == null)
            {
                return new BaseReturn("Tipo Chamado", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, true);
            }

            DadosTipoChamado = DadosTipoChamado.AlterarTipoChamados(descricao, nome, sla);

            if (DadosTipoChamado.IsInvalid())
            {
                return new BaseReturn(DadosTipoChamado.Notifications.FirstOrDefault().Property, DadosTipoChamado.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryTipoChamado.Edit(DadosTipoChamado);

            return new BaseReturn("Tipo de Chamado", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }
    }
}
