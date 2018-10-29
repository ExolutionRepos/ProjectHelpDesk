using System.Collections.Generic;
using System.Linq;

namespace UI.Business.Interfaces.Repositories
{
    public interface IMetodos<T> where T : new()
    {
        int INSERIRREGISTRO(T objModel);
        string ATUALIZARREGISTRO<P>(T objModel);
        string EXCLUIRREGISTRO<P>(P id);
        List<T> CONSULTARREGISTRO(T objModel);
    }
}
