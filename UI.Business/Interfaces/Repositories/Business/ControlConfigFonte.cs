using Library.Class.Models;
using Library.Class.Resources;
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

        public BaseReturn Cadastrar(int codigousuario, string fonte, float tamanho)
        {
            Usuarios DadosUsuarios = _RepositoryUsuario.Find(codigousuario);

            if(DadosUsuarios == null)
            {
                return new BaseReturn("Usuario ",Message.DADOS_NAO_ENCONTRADOS, false);
            }

            ConfigFont dadosFonte = new ConfigFont(fonte, tamanho);

            if (dadosFonte.IsInvalid())
            {
                return new BaseReturn(dadosFonte.Notifications.FirstOrDefault().Property, dadosFonte.Notifications.FirstOrDefault().Message, false);
            }

            DadosUsuarios.Fonte.Add(dadosFonte);

            _RepositoryUsuario.Edit(DadosUsuarios);

            return new BaseReturn();
        }

        public BaseReturn Alterar(int codigousuario, string fonte, float tamanho)
        {
            Usuarios DadosUsuarios = _RepositoryUsuario.Find(codigousuario);

            if (DadosUsuarios == null)
            {
                return new BaseReturn("Usuario ", Message.DADOS_NAO_ENCONTRADOS, false);
            }

            ConfigFont dadosFonte = _RepositoryConfigFont.List()
                .Where(x => x.CodigoUsuario == codigousuario)
                .FirstOrDefault();

            if (dadosFonte == null)
            {
                return new BaseReturn("Fonte ", Message.DADOS_NAO_ENCONTRADOS, false);
            }

            dadosFonte.AlterarConfigFont(fonte, tamanho);

            _RepositoryConfigFont.Edit(dadosFonte);

            return new BaseReturn();
        }

        public BaseReturn Remover(int codigofonte)
        {
            var DadosFonte = Pesquisar(codigofonte);

            if (DadosFonte == null)
            {
                return new BaseReturn("Fonte ", Message.DADOS_NAO_ENCONTRADOS, false);
            }

            _RepositoryConfigFont.Remove(DadosFonte);

            return new BaseReturn();
        }
    }
}
