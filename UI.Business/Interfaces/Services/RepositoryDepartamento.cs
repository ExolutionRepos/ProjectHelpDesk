using System.Collections.Generic;
using Library.Class.Models;
using UI.Business.Arguments;
using UI.Business.Arguments.Departamento;
using UI.Business.Interfaces.Repositories;

namespace UI.Business.Interfaces.Services
{
    class RepositoryDepartamento : IRepositoryDepartamento
    {
        public ResponseDepartamentoAdi AdicionarDepartamento(RequestDepartamentoAdi Request)
        {
            throw new System.NotImplementedException();
        }

        public ResponseBase AlterarDepartamento(RequestDepartamentoAlt Request)
        {
            throw new System.NotImplementedException();
        }

        public ResponseDepartamentoCon ConsultarDepartamento(RequestDepartamentoCon Request)
        {
            throw new System.NotImplementedException();
        }

        public ResponseBase DeletarDepartamento(RequestDepartamentoDel Request)
        {
            throw new System.NotImplementedException();
        }

        public List<Departamentos> UConsultarDepartamento(Departamentos Request)
        {
            throw new System.NotImplementedException();
        }

        public List<Departamentos> UConsultarDepartamento(RequestDepartamentoCon Request)
        {
            throw new System.NotImplementedException();
        }
    }
}
