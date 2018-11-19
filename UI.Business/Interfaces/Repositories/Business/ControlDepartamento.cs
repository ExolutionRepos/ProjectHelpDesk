using Library.Class.Models;
using System.Linq;
using UI.Business.Interfaces.Services;
using prmToolkit.NotificationPattern.Extensions;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlDepartamento
    {

        private readonly BaseService<Departamentos> _RepositoryDepartamento;

        public ControlDepartamento()
        {
            _RepositoryDepartamento = new BaseService<Departamentos>();
        }

        public Departamentos Pesquisar(int id)
        {
            return _RepositoryDepartamento.Find(id);
        }


        public IQueryable<Departamentos> PesquisarDepartamento(string nome)
        {
            var retorno = _RepositoryDepartamento.List()
                .Where(query => query.Nome.Contains(nome));

            return retorno;
        }

        public IQueryable<Departamentos> PesquisarDepartamento()
        {
            var retorno = _RepositoryDepartamento.List();

            return retorno;
        }

        public BaseReturn CadastrarDepartamento(string nome,string descricao)
        {
            var Dados = PesquisarDepartamento()
              .Where(y => y.Nome == nome).FirstOrDefault();

            if (Dados != null)
            {
                return new BaseReturn("Departamento", Library.Class.Resources.Message.JA_EXISTE_UMA_X0_CHAMADA_X1.ToFormat("Nome", Dados.Nome.ToString()), true);
            }


            Departamentos DadosDepartamentos = new Departamentos(descricao, nome);

            if (DadosDepartamentos.IsInvalid())
            {
                return new BaseReturn(DadosDepartamentos.Notifications.FirstOrDefault().Property, DadosDepartamentos.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryDepartamento.Add(DadosDepartamentos);

            return new BaseReturn("Departamento", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

        public BaseReturn AlterarDepartamento(int codigotipo, string nome, string descricao)
        {
            var DadosDepartamento = Pesquisar(codigotipo);

            if (DadosDepartamento == null)
            {
                return new BaseReturn("Tipo Usuario", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, true);
            }

            DadosDepartamento = DadosDepartamento.AlterarDepartamento(descricao, nome);

            if (DadosDepartamento.IsInvalid())
            {
                return new BaseReturn(DadosDepartamento.Notifications.FirstOrDefault().Property, DadosDepartamento.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryDepartamento.Edit(DadosDepartamento);

            return new BaseReturn("Departamento", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }
    }
}
