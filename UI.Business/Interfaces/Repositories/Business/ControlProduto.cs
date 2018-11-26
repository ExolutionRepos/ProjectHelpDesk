using Library.Class.Models;
using prmToolkit.NotificationPattern.Extensions;
using System.Linq;
using UI.Business.Interfaces.Services;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlProduto
    {
        private readonly BaseService<Produtos> _RepositoryProduto;

        public ControlProduto()
        {
            _RepositoryProduto = new BaseService<Produtos>();
        }

        public Produtos Pesquisar(int id)
        {
            return _RepositoryProduto.Find(id);
        }


        public IQueryable<Produtos> PesquisarProduto(string nome)
        {
            var retorno = _RepositoryProduto.List()
                .Where(query => query.Nome.Contains(nome));

            return retorno;
        }

        public IQueryable<Produtos> PesquisarProduto()
        {
            var retorno = _RepositoryProduto.List();

            return retorno;
        }

        public BaseReturn CadastrarProduto(string nome, string descricao, Library.Class.Enum.EnumMarca.Marcas marca, Library.Class.Enum.EnumModelo.Modelos modelo)
        {
            var Dados = PesquisarProduto()
              .Where(y => y.Nome == nome).FirstOrDefault();

            if (Dados != null)
            {
                return new BaseReturn("Produto", Library.Class.Resources.Message.JA_EXISTE_UMA_X0_CHAMADA_X1.ToFormat("Nome", Dados.Nome.ToString()), true);
            }


            Produtos DadosProdutos = new Produtos(descricao,marca,modelo,nome);

            if (DadosProdutos.IsInvalid())
            {
                return new BaseReturn(DadosProdutos.Notifications.FirstOrDefault().Property, DadosProdutos.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryProduto.Add(DadosProdutos);

            return new BaseReturn("Produto", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

        public BaseReturn AlterarProduto(int codigoproduto,string nome, string descricao, Library.Class.Enum.EnumMarca.Marcas marca, Library.Class.Enum.EnumModelo.Modelos modelo)
        {
            var DadosProduto = Pesquisar(codigoproduto);

            if (DadosProduto == null)
            {
                return new BaseReturn("Produto", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }

            DadosProduto = DadosProduto.AlterarProdutos(descricao,marca,modelo,nome);

            if (DadosProduto.IsInvalid())
            {
                return new BaseReturn(DadosProduto.Notifications.FirstOrDefault().Property, DadosProduto.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryProduto.Edit(DadosProduto);

            return new BaseReturn("Produto", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }
    }
}
