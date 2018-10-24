using Library.Class.Models;
using System.Collections.Generic;
using UI.Business.Arguments;
using UI.Business.Arguments.Departamento;

namespace UI.Business.Interfaces.Repositories
{
    interface IRepositoryDepartamento
    {
        ResponseDepartamentoAdi AdicionarDepartamento(RequestDepartamentoAdi Request);

        ResponseBase AlterarDepartamento(RequestDepartamentoAlt Request);

        ResponseDepartamentoCon ConsultarDepartamento(RequestDepartamentoCon Request);
        
        ResponseBase DeletarDepartamento(RequestDepartamentoDel Request);

        List<Departamentos> UConsultarDepartamento(Departamentos Request);

        List<Departamentos> UConsultarDepartamento(RequestDepartamentoCon Request);
    }
}
