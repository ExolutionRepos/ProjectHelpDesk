using System;
using UI.Business.Arguments.Endereco;
using static Library.Class.Enum.EnumSexo;

namespace UI.Business.Arguments.Usuario
{
    public class RequestUsuarioAdi : RequestEnderecoAdi
    {

        public string nome { get;  set; }

        public DateTime? datanascimento { get; private set; }

        public string email { get; private set; }

        public string cpf { get; private set; }

        public Sexo sexo { get; private set; }

        public string telefone { get; private set; }

        public string celular { get; private set; }

        public int codigoendereco { get; private set; }
    }
}
