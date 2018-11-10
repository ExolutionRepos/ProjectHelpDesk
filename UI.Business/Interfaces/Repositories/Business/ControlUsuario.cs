using Library.Class.Models;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Linq;
using UI.Business.Interfaces.Services;
using static Library.Class.Enum.EnumSexo;
using static Library.Class.Utils.StringExtension;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlUsuario
    {

        private readonly BaseService<Usuarios> _RepositoryUsuario;
        private readonly BaseService<Departamentos> _RepositoryDepartamento;
        private readonly BaseService<TipoUsuarios> _RepositoryTipoUsuario;
        private readonly BaseService<Enderecos> _RepositoryEndereco;

        public ControlUsuario()
        {
            _RepositoryUsuario = new BaseService<Usuarios>();
            _RepositoryDepartamento = new BaseService<Departamentos>();
            _RepositoryTipoUsuario = new BaseService<TipoUsuarios>();
            _RepositoryEndereco = new BaseService<Enderecos>();
        }

        public BaseReturn CadastrarUsuario(string nome, DateTime? datanascimento, string email, string cpf, Sexo sexo, string telefone, string celular
            , string rua, string bairro, string cep, string cidade, int numero, string uf
            , int codigotipousuario)
        {
            if (PesquisarUsuario().Where(y => y.CPF == cpf).FirstOrDefault() != null)
            {
                return new BaseReturn("Usuario", Library.Class.Resources.Message.JA_EXISTE_UM_X0_COM_O_X1_X2.ToFormat("Usuario", "CPF: ", cpf), false);
            }

            Usuarios DadosUsuarios = new Usuarios(nome, datanascimento, email, cpf, sexo, telefone, celular);

            if (DadosUsuarios.IsInvalid())
            {
                return new BaseReturn(DadosUsuarios.Notifications.FirstOrDefault().Property, DadosUsuarios.Notifications.FirstOrDefault().Message, false);
            }

            // Cadastro de endereço
            Enderecos DadosEndereco = new Enderecos(rua, bairro, cep, cidade, numero, uf);

            if (DadosEndereco.IsInvalid())
            {
                return new BaseReturn(DadosEndereco.Notifications.FirstOrDefault().Property, DadosEndereco.Notifications.FirstOrDefault().Message, false);
            }

            DadosEndereco.Usuario.Add(DadosUsuarios);

            //Não salvar, somente adicionar
            _RepositoryEndereco.AddNotSave(DadosEndereco);

            // Tipo de Usuarios
            TipoUsuarios TipoUsuario = _RepositoryTipoUsuario.Find(codigotipousuario);
            //cadastro tipo de usuario
            TipoUsuario.Usuario.Add(DadosUsuarios);
            //Adicionar
            _RepositoryTipoUsuario.Edit(TipoUsuario);


            return new BaseReturn("Usuario", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);

        }


        public BaseReturn AlterarUsuario(int CodigoUsuario, string nome, DateTime? datanascimento, string email, string cpf, Sexo sexo, string telefone, string celular
            , string rua, string bairro, string cep, string cidade, int? numero, string uf
            , int codigotipousuario)
        {

            Usuarios DadosUsuarios = _RepositoryUsuario.Find(CodigoUsuario);

            if (DadosUsuarios == null)
            {
                return new BaseReturn("Usuario", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, true);
            }

            Enderecos DadosEnderecos = DadosUsuarios.Endereco.AlterarEnderecos(rua, bairro, cep, cidade, numero, uf, DadosUsuarios);

            if (DadosEnderecos.IsInvalid())
            {
                return new BaseReturn(DadosEnderecos.Notifications.FirstOrDefault().Property, DadosEnderecos.Notifications.FirstOrDefault().Message, false);
            }

            TipoUsuarios DadosTiposUsuarios = _RepositoryTipoUsuario.Find(codigotipousuario);

            if (DadosTiposUsuarios == null)
            {
                return new BaseReturn("Tipos Usuarios", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, true);
            }

            DadosUsuarios.AlterarUsuarios(nome, datanascimento, email, cpf, sexo, telefone, celular, DadosEnderecos, DadosTiposUsuarios);

            if (DadosUsuarios.IsInvalid())
            {
                return new BaseReturn(DadosUsuarios.Notifications.FirstOrDefault().Property, DadosUsuarios.Notifications.FirstOrDefault().Message, false);
            }

            _RepositoryUsuario.Edit(DadosUsuarios);

            return new BaseReturn("Usuario", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

        public IQueryable<Usuarios> PesquisarUsuario(string nome)
        {
            var retorno = _RepositoryUsuario.List()
                .Where(query => query.Nome.Contains(nome));

            return retorno;
        }


        public IQueryable<Usuarios> PesquisarUsuario()
        {
            var retorno = _RepositoryUsuario.List();

            return retorno;
        }

        public Usuarios PesquisarUsuario(Logins login)
        {
            var retorno = _RepositoryUsuario.List()
                .Where(y => y.CodigoLogin == login.CodigoLogin)
                .FirstOrDefault();

            return retorno;
        }



        public Usuarios Pesquisar(int id)
        {
            return _RepositoryUsuario.Find(id);
        }

        public BaseReturn Remover(int id)
        {
            Usuarios DadosUsuarios = _RepositoryUsuario.Find(id);

            if (DadosUsuarios == null)
            {
                return new BaseReturn("Usuario", Library.Class.Resources.Message.DADOS_NAO_ENCONTRADOS, true);
            }

            _RepositoryUsuario.Remove(DadosUsuarios);
            return new BaseReturn("Usuario", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO, true);
        }

    }
}
