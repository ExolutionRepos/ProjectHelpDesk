using Library.Class.Models;
using System.Linq;
using UI.Business.Interfaces.Services;

namespace UI.Business.Interfaces.Repositories.Business
{
    public class ControlConfigFonte
    {

        private readonly BaseService<ConfigFont> _RepositoryConfigFont;
        private readonly BaseService<Usuarios> _RepositoryUsuario;

        public ControlConfigFonte()
        {
            _RepositoryConfigFont = new BaseService<ConfigFont>();
            _RepositoryUsuario = new BaseService<Usuarios>();
        }

        public ConfigFont Pesquisar(int id)
        {
            var DadosUsuario = _RepositoryUsuario.Find(id);

            if (DadosUsuario == null)
                return null;

            var Dados = _RepositoryConfigFont.List().Where(x => x.Usuario == DadosUsuario).FirstOrDefault();

            return _RepositoryConfigFont.Find(Dados.Codigo_ConfigFont);
        }


    }
}
