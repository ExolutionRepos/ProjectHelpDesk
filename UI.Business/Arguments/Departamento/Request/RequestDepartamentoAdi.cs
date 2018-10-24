using System;
using UI.Business.Arguments.Endereco;

namespace UI.Business.Arguments.Departamento
{
    public class RequestDepartamentoAdi : RequestEnderecoAdi
    {

        public string nome { get;  set; }

        public DateTime? datanascimento { get; private set; }

        public string email { get; private set; }

        public string cpf { get; private set; }

        public Library.Class.Enum.EnumSexo.Sexo sexo { get; private set; }

        public string telefone { get; private set; }

        public string celular { get; private set; }

        public int codigoendereco { get; private set; }
    }
}
