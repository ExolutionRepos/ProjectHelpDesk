using Library.Class.Models;

namespace UI.Business.Arguments.Departamento
{
    public class ResponseDepartamentoAdi
    {
        public int CodigoDepartamento { get; set; }

        public string Nome { get; set; }

        public static explicit operator ResponseDepartamentoAdi(Departamentos entidade)
        {
            return new ResponseDepartamentoAdi()
            {
                CodigoDepartamento = entidade.CodigoDepartamento,
                Nome = entidade.Nome
            };
        }
    }
}
