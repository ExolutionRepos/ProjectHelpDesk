using Library.Class.Class;
using System;
using UI.Business.Arguments.Usuario;
using UI.Business.Interfaces.Repositories;
using UI.Business.Persistence;

namespace UI.Business.Repositories
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        private BaseContext _db = new BaseContext(@"Server=.\SQLEXPRESS;UID=sa;PWD=123456;Language=us_english;DATABASE=HelpDesk");
        
        public void AdicionarioUsuario()
        {
            var a = "";

            try
            {
                var usuarios = new Usuarios("rogerio") { };


                _db.Usuarios.Add(usuarios);
                _db.SaveChanges();
            }

            catch (Exception ex)
            {
                a = ex.Message;
            }
        }

        public ResponseUsuario AdicionarUsuario(RequestUsuario Request)
        {
            throw new NotImplementedException();
        }

        public ResponseUsuario AlterarUsuario(RequestUsuario Request)
        {
            throw new NotImplementedException();
        }
    }
}
