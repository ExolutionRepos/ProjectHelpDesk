using Library.Class.Models;
using System.Collections.Generic;

namespace UI.Business.Persistence
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Message = Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO;
        }

        public ResponseBase(Library.Class.Resources.Message message)
        {
            Message = message.ToString();
        }
        public Dictionary<string, string> ResponseBaseDictionary { get; set; }

        public string Message { get; set; }

        public static explicit operator ResponseBase(Usuarios entidade)
        {
            return new ResponseBase()
            {
                Message = Library.Class.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}