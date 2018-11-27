using Library.Class.Models;
using prmToolkit.NotificationPattern.Extensions;
using System.Linq;
using UI.Business.Interfaces.Services;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlBaseConhecimento
    {
        private readonly BaseService<BaseConhecimento> _RepositoryBaseConhecimento;
        private readonly BaseService<TipoChamados> _ReposistoryTipoChamado;

        public ControlBaseConhecimento()
        {
            _RepositoryBaseConhecimento = new BaseService<BaseConhecimento>();
            _ReposistoryTipoChamado = new BaseService<TipoChamados>();
        }
      
        public BaseConhecimento Pesquisar(int CodigoBaseConhecimento)
        {
            return _RepositoryBaseConhecimento.Find(CodigoBaseConhecimento);
        }


        public IQueryable<BaseConhecimento> PesquisarBaseConhecimento(string Nome)
        {
            var retorno = _RepositoryBaseConhecimento.List()
                .Where(query => query.Nome.Contains(Nome));

            return retorno;
        }

        public IQueryable<BaseConhecimento> PesquisarBaseConhecimento()
        {
            var retorno = _RepositoryBaseConhecimento.List();

            return retorno;
        }

        public BaseReturn CadastrarBaseConhecimento(string descricao, string nome, string palavrachave,int codigotipochamado)
        {
            var Dados = PesquisarBaseConhecimento()
              .Where(y => y.Nome == nome).FirstOrDefault();

            if (Dados != null)
            {
                return new BaseReturn("BaseConhecimento", Library.Class.Resources.Message.JA_EXISTE_UMA_X0_CHAMADA_X1.ToFormat("Nome", Dados.Nome.ToString()), true);
            }


            BaseConhecimento baseconhecimento = new BaseConhecimento(descricao, nome, palavrachave);

            if (baseconhecimento.IsInvalid())
            {
                return new BaseReturn(baseconhecimento.Notifications.FirstOrDefault().Property, baseconhecimento.Notifications.FirstOrDefault().Message, false);
            }

            var DadosTipoChamado = _ReposistoryTipoChamado.Find(codigotipochamado);

            if (DadosTipoChamado == null)
            {
                return new BaseReturn("Tipo Chamado", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }

            DadosTipoChamado.BaseConhecimento.Add(baseconhecimento);

            //_RepositoryBaseConhecimento.Add(baseconhecimento);
            _ReposistoryTipoChamado.Edit(DadosTipoChamado);

            return new BaseReturn("BaseConhecimento", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

        public BaseReturn AlterarBaseConhecimento(int codigobaseconhecimento,  string descricao, string nome, string palavrachave, int tipochamado)
        {
            var DadosBaseConhecimento = Pesquisar(codigobaseconhecimento);

            if (DadosBaseConhecimento == null)
            {
                return new BaseReturn("Dados Conhecimento", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }

            var DadosTipoChamado = _ReposistoryTipoChamado.Find(tipochamado);

            if (DadosTipoChamado == null)
            {
                return new BaseReturn("Tipo Chamado", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }

            DadosBaseConhecimento = DadosBaseConhecimento.AlterarBaseConhecimento(descricao, nome, palavrachave, tipochamado);

            if (DadosBaseConhecimento.IsInvalid())
            {
                return new BaseReturn(DadosBaseConhecimento.Notifications.FirstOrDefault().Property, DadosBaseConhecimento.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryBaseConhecimento.Edit(DadosBaseConhecimento);

            return new BaseReturn("BaseConhecimento", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }
    }
}
