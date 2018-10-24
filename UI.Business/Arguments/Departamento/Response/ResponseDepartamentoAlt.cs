using Library.Class.Models;

namespace UI.Business.Arguments.Departamento
{
    public class ResponseDepartamentoAlt
    {
        
        public string sNome { get; set; }

        public static explicit operator ResponseDepartamentoAlt(Usuarios entidade)
        {
            {
                return new ResponseDepartamentoAlt()
                {
                    sNome = entidade.Nome
                };
            }
        }
    }
}
