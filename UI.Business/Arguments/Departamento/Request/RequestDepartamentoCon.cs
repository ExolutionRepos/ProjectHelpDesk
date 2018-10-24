namespace UI.Business.Arguments.Departamento
{
    public class RequestDepartamentoCon
    {
        public int CodigoUsuario { get; set; }

        public static explicit operator RequestDepartamentoCon(int codigousuario)
        {
            return new RequestDepartamentoCon
            {
                CodigoUsuario = codigousuario
            };
        }
    }
}
