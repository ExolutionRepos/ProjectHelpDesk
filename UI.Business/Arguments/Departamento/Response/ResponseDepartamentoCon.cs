namespace UI.Business.Arguments.Departamento
{
    public class ResponseDepartamentoCon
    {
        public string Nome { get; set; }

        public static explicit operator ResponseDepartamentoCon(string entidade)
        {
            return new ResponseDepartamentoCon
            {
                Nome = entidade
            };
        }
    }
}
