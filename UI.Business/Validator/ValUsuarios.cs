using Library.Class.Models;
using System;
using UI.Business.Interfaces.Services;
using static Library.Class.Enum.EnumSexo;

namespace UI.Business.Validator
{
    public class ValUsuarios
    {
        private readonly BaseService<Usuarios> _RepositoryUsuario;
        private readonly BaseService<Enderecos> _RepositoryEndereco;

        public ValUsuarios()
        {
            _RepositoryUsuario = new BaseService<Usuarios>();
            _RepositoryEndereco = new BaseService<Enderecos>();
        }

        public string Cadastrar(string nome, DateTime? datanascimento, string email, string cpf, Sexo sexo,
            string telefone, string celular, string rua)
        {
            var DadosEndereco = new Enderecos(rua);

            var DadosUsuario = new Usuarios(nome, datanascimento, email, cpf, sexo,
            telefone, celular, DadosEndereco);

            _RepositoryUsuario.Add(DadosUsuario);

            return DadosUsuario.Nome;
        }

        public string Alterar(int CodigoUsuario, int CodigoEndereco, string nome, DateTime? datanascimento, string email, string cpf, Sexo sexo,
            string telefone, string celular, string rua)
        {
            var DadosEndereco = _RepositoryEndereco.Find(CodigoEndereco);

            var DadosUsuario = _RepositoryUsuario.Find(CodigoUsuario);
            
            _RepositoryUsuario.Edit(DadosUsuario);

            return DadosUsuario.Nome;
        }
    }
}
