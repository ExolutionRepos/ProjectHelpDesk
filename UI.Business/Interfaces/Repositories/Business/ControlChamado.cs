using Library.Class.Models;
using System;
using System.Linq;
using UI.Business.Interfaces.Services;
using static Library.Class.Enum.EnumChamado;
using static Library.Class.Enum.EnumStatusChamado;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlChamado
    {
        private readonly BaseService<Chamados> _RepositoryChamado;
        private readonly BaseService<TipoChamados> _RepositoryTipoChamado;
        private readonly BaseService<Produtos> _RepositoryProduto;
        private readonly BaseService<Usuarios> _RepositoryUsuario;
        private readonly BaseService<Departamentos> _RepositoryDepartamento;
        private readonly BaseService<TipoUsuarios> _RepositoryTipoUsuario;

        public ControlChamado()
        {
            _RepositoryChamado = new BaseService<Chamados>();
            _RepositoryTipoChamado = new BaseService<TipoChamados>();
            _RepositoryProduto = new BaseService<Produtos>();
            _RepositoryUsuario = new BaseService<Usuarios>();
            _RepositoryDepartamento = new BaseService<Departamentos>();
            _RepositoryTipoUsuario = new BaseService<TipoUsuarios>();
        }

        public Chamados Pesquisar(int id)
        {
            return _RepositoryChamado.Find(id);
        }

        public IQueryable<Chamados> PesquisarChamado(string nome)
        {
            var retorno = _RepositoryChamado.List()
                .Where(query => query.Descricao.Contains(nome));

            return retorno;
        }

        public IQueryable<Chamados> PesquisarChamadoStatusChamado(StatusChamado statuschamado)
        {
            var retorno = _RepositoryChamado.List()
                .Where(query => query.Status == statuschamado);

            return retorno;
        }

        public IQueryable<Chamados> PesquisarChamado(StatusChamado statuschamado)
        {
            var retorno = _RepositoryChamado.List()
                .Where(query => query.Status == statuschamado);

            return retorno;
        }


        public IQueryable<Chamados> PesquisarChamado()
        {
            var retorno = _RepositoryChamado.List();

            return retorno;
        }

        public BaseReturn Remover(int id)
        {
            Chamados DadosChamado = _RepositoryChamado.Find(id);

            if (DadosChamado == null)
            {
                return new BaseReturn("Chamado", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }

            _RepositoryChamado.Remove(DadosChamado);
            return new BaseReturn("Chamado", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

        public string RetornaChamado(int codigochamado)
        {
            var chamado = Pesquisar(codigochamado);

            if (chamado != null)
                return chamado.ToString();

            return null;
        }

        public BaseReturn CadastrarChamado(string descricao, string observacao, StatusChamado status, ChamadoPrioridade prioridade,
            int codigotipochamado,
            int codigoproduto,
            int codigocliente,
            int codigofuncionario,
            int? codigodepartamento,
            DateTime datagarantia)
        {
            if(descricao == null || observacao == null)
                return new BaseReturn("Descricão", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);

          
            TipoChamados DadosTipoChamado = _RepositoryTipoChamado.Find(codigotipochamado);

            if (DadosTipoChamado == null)
            {
                return new BaseReturn("Tipo Chamado", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }


            Produtos DadosProduto = _RepositoryProduto.Find(codigoproduto);

            if (DadosProduto == null)
            {
                return new BaseReturn("Produto", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }



            Usuarios DadosCliente =_RepositoryUsuario.Find(codigocliente);

            if (DadosCliente == null)
            {
                return new BaseReturn("Cliente", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }



            Usuarios DadosFuncionario = _RepositoryUsuario.Find(codigofuncionario);

            if (DadosFuncionario == null)
            {
                return new BaseReturn("Funcionario", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }



            Departamentos DadosDepartamento = _RepositoryDepartamento.Find(Convert.ToInt32(codigodepartamento));
            
            if (DadosDepartamento.IsInvalid())
            {
                return new BaseReturn(DadosDepartamento.Notifications.FirstOrDefault().Property, DadosDepartamento.Notifications.FirstOrDefault().Message, false);
            }

            Chamados DadosChamados = new Chamados(descricao, observacao, status, prioridade,
              codigotipochamado, codigoproduto, codigocliente, codigofuncionario, codigodepartamento, datagarantia);

            DadosTipoChamado.Chamado.Add(DadosChamados);
            
            DadosProduto.Chamado.Add(DadosChamados);
            
            DadosDepartamento.Chamado.Add(DadosChamados);

            _RepositoryDepartamento.Edit(DadosDepartamento);

            Library.Class.Utils.ExtensionEmail.EnviarEmail("Caro " + _RepositoryUsuario.Find(DadosChamados.CodigoUsuario_Cliente).Nome + " \n \n Obrigado por entrar em contato. \n Chamado cadastrado." + " \n \n O " + DadosChamados.Produto.Nome + " , foi informado que " + DadosChamados.Descricao + " com a observação de " + DadosChamados.Observacao.ToString() + " .", _RepositoryUsuario.Find(DadosChamados.CodigoUsuario_Cliente).Email);

            return new BaseReturn("Chamado", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);

        }

        public BaseReturn AlterarChamado(int codigochamado, string descricao, string observacao, StatusChamado status, ChamadoPrioridade prioridade,
           int codigotipochamado,
           int codigoproduto,
           int codigocliente,
           int codigofuncionario,
           int? codigodepartamento,
           DateTime datagarantia)
        {
            if (descricao == null || observacao == null)
                return new BaseReturn("Descricão", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);


            TipoChamados DadosTipoChamado = _RepositoryTipoChamado.Find(codigotipochamado);

            if (DadosTipoChamado == null)
            {
                return new BaseReturn("Tipo Chamado", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }


            Produtos DadosProduto = _RepositoryProduto.Find(codigoproduto);

            if (DadosProduto == null)
            {
                return new BaseReturn("Produto", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }



            Usuarios DadosCliente = _RepositoryUsuario.Find(codigocliente);

            if (DadosCliente == null)
            {
                return new BaseReturn("Cliente", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }



            Usuarios DadosFuncionario = _RepositoryUsuario.Find(codigofuncionario);

            if (DadosFuncionario == null)
            {
                return new BaseReturn("Funcionario", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }

            Departamentos DadosDepartamento = _RepositoryDepartamento.Find(Convert.ToInt32(codigodepartamento));

            if (DadosDepartamento.IsInvalid())
            {
                return new BaseReturn(DadosDepartamento.Notifications.FirstOrDefault().Property, DadosDepartamento.Notifications.FirstOrDefault().Message, false);
            }

            Chamados DadosChamados = _RepositoryChamado.Find(codigochamado).Alterarchamado(descricao, observacao, status, prioridade,
              codigotipochamado, codigoproduto, codigocliente, codigofuncionario, codigodepartamento, datagarantia);

            _RepositoryChamado.Edit(DadosChamados);

            return new BaseReturn("Chamado", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }



        public BaseReturn AlterarStatus(int codigochamado, StatusChamado status)
        {
            Chamados DadosChamados = Pesquisar(codigochamado);

            if(DadosChamados == null)
            {
                return new BaseReturn("Chamado ", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, false);
            }

            DadosChamados = DadosChamados.AlterarStatusChamado(status);

            _RepositoryChamado.Edit(DadosChamados);

            Library.Class.Utils.ExtensionEmail.EnviarEmail("Caro " + _RepositoryUsuario.Find(DadosChamados.CodigoUsuario_Cliente).Nome + " \n \n O status do seu chamado foi atualizado, " + DadosChamados.Status.ToString() + " \n \n O " + DadosChamados.Produto.Nome + " , foi informado que " + DadosChamados.Descricao + " com a observação de " + DadosChamados.Observacao.ToString() + " .", _RepositoryUsuario.Find(DadosChamados.CodigoUsuario_Cliente).Email.ToString());

            return new BaseReturn("Chamado", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);

        }

    }
}
