using Library.Class.Class;
using System;
using UI.Business.Persistence;

namespace UI.Business.Repositories
{
    public class Usuario
    {
        private BaseContext _db = new BaseContext(@"Server=NBTA117771\GCAP;UID=sa;PWD=123456;Language=us_english;DATABASE=HelpDesk");

        public void CadastroUsuario()
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
    }
}
