namespace UI.Business.Interfaces.Services
{
    public class BaseReturn
    {
        public string Propert { get; private set; }

        public string Message { get; private set; }

        public bool Status { get; private set; }

        public BaseReturn(string propert, string message, bool status)
        {
            this.Propert = propert;
            this.Message = message;
            this.Status = status;
        }

        public BaseReturn()
        {
            this.Message = Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO;
            this.Status = true;
        }
    }
}
