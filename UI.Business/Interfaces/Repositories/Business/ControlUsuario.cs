﻿using Library.Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Business.Interfaces.Services;
using static Library.Class.Enum.EnumSexo;

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
            , string rua, string bairro, string cep, string cidade, int? numero, string uf
            , int codigotipousuario)
        {
            
            Usuarios DadosUsuarios = new Usuarios(nome, datanascimento, email, cpf, sexo, telefone, celular);

            if (DadosUsuarios.IsInvalid())
            {
                return new BaseReturn(DadosUsuarios.Notifications.FirstOrDefault().Property, DadosUsuarios.Notifications.FirstOrDefault().Message,false);
            }

            TipoUsuarios TipoUsuario = _RepositoryTipoUsuario.Find(codigotipousuario);

            //cadastro tipo de usuario
            TipoUsuario.Usuario.Add(DadosUsuarios);

            //Não salvar, somente adicionar
            _RepositoryTipoUsuario.AddNotSave(TipoUsuario);

            // Cadastro de endereço
            Enderecos DadosEndereco = new Enderecos(rua, bairro, cep, cidade, numero,uf);

            if (DadosEndereco.IsInvalid())
            {
                return new BaseReturn(DadosEndereco.Notifications.FirstOrDefault().Property, DadosEndereco.Notifications.FirstOrDefault().Message,false);
            }

            DadosEndereco.Usuario.Add(DadosUsuarios);

            //Não salvar, somente adicionar
            _RepositoryEndereco.AddNotSave(DadosEndereco);

            //Add
            _RepositoryUsuario.Add(DadosUsuarios);

            return new BaseReturn("Usuario", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO,true);

        }


        public BaseReturn AlterarUsuario(int CodigoUsuario, string nome, DateTime? datanascimento, string email, string cpf, Sexo sexo, string telefone, string celular
            , string rua, string bairro, string cep, string cidade, int? numero, string uf
            , int codigotipousuario)
        {
            Usuarios DadosUsuarios = _RepositoryUsuario.Find(CodigoUsuario);
            
            DadosUsuarios.AlterarUsuarios(nome, datanascimento, email, cpf, sexo, telefone, celular);

            if (DadosUsuarios.IsInvalid())
            {
                return new BaseReturn(DadosUsuarios.Notifications.FirstOrDefault().Property, DadosUsuarios.Notifications.FirstOrDefault().Message,false);
            }

            _RepositoryUsuario.Edit(DadosUsuarios);
            
            return new BaseReturn("Usuario", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO,true);

        }

        public IQueryable<Usuarios> PesquisarUsuario(string nome)
        {
            var retorno = _RepositoryUsuario.List()
                .Where(query => query.Nome.Contains(nome));

            return retorno;
        }

        public Usuarios Pesquisar(int id)
        {
            return _RepositoryUsuario.Find(id);
        }

        public BaseReturn Remover(int id)
        {
            _RepositoryUsuario.Remove(_RepositoryUsuario.Find(id));

            return new BaseReturn("Usuario", Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO,true);
        }

    }
}