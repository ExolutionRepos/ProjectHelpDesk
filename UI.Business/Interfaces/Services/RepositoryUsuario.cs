using Library.Class.Class;
using Library.Class.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UI.Business.Arguments.Usuario;
using UI.Business.Arguments.Usuario.Request;
using UI.Business.Arguments.Usuario.Response;
using UI.Business.Interfaces.Repositories;
using UI.Business.Persistence;

namespace UI.Business.Repositories
{
    public class RepositoryUsuario : Notifiable, IRepositoryUsuario
    {
        private BaseContext _db = new BaseContext("Server=.\SQLEXPRESS;UID=sa;PWD=123456;Language=us_english;DATABASE=HelpDesk");
        
        public ResponseUsuarioAdi AdicionarUsuario(RequestUsuarioAdi Request)
        {
            if (Request == null)
            {
                AddNotification("Adicionar", Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("AdicionarUsuario"));
                return null;
            }


            var ListaEnderecoT = new Enderecos(1,"Test");
            var ListaUsuarios = new Usuarios(Request.nome,null,"rogerio@gmail.com","",Library.Class.Enum.EnumSexo.Sexo.Masculino,"1111111", "1111111",ListaEnderecoT) { };

            //var ListaUsuarios = new Usuarios(Request.nome) { };

            AddNotifications(ListaUsuarios);

            if (this.IsInvalid())
            {
                return null;
            }


            var a = "";
            try
            {

                _db.Usuarios.Add(ListaUsuarios);
                _db.SaveChanges();
                return (ResponseUsuarioAdi)ListaUsuarios;
            }
            catch(Exception e)
            {
                 a = e.Message;
            }
            return (ResponseUsuarioAdi)ListaUsuarios;

        }



        public ResponseBase AlterarUsuario(RequestUsuarioAlt Request)
        {
            if (Request == null)
            {
                AddNotification("Alterar", Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("AlterarUsuario"));
            }

            Usuarios Alteracao = UConsultarUsuario((RequestUsuarioCon)Request.CodigoUsuario);

            if (Alteracao == null)
            {
                AddNotification("Alterar", Message.DADOS_NAO_ENCONTRADOS);
            }

            if (IsInvalid())
            {
                var retorno = new ResponseBase();
                retorno.ResponseBaseDictionary = Notifications.ToDictionary(t => t.Property, t => t.Message);
                return retorno;
            }

            Alteracao.AlterarUsuarios(Alteracao.CodigoUsuario, Request.Nome);

            AddNotifications(Alteracao);

            if (IsInvalid())
            {
                return new ResponseBase() { Message = Alteracao.Notifications.ToString() };
            }

            _db.Usuarios.Attach(Alteracao);
            _db.Entry(Alteracao).State = EntityState.Modified;
            _db.SaveChanges();

            return new ResponseBase();
        }


        public ResponseUsuarioLis ConsultarListaUsuario(RequestUsuarioLis Request)
        {
            throw new NotImplementedException();
        }


        public ResponseBase DeletarUsuario(RequestUsuarioDel Request)
        {
            if (Request == null)
            {
                AddNotification("Deletar", Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("DeletarUsuario"));
                return null;
            }

            Usuarios Delete = UConsultarUsuario((RequestUsuarioCon)Request.CodigoUsuario);

            if (Delete == null)
            {
                AddNotification("Deletar", Message.DADOS_NAO_ENCONTRADOS);
            }

            if (IsInvalid())
            {
                var retorno = new ResponseBase();
                retorno.ResponseBaseDictionary = Notifications.ToDictionary(t => t.Property, t => t.Message);
                return retorno;
            }

            _db.Usuarios.Attach(Delete);
            _db.Usuarios.Remove(Delete);
            _db.SaveChanges();

            return new ResponseBase();
        }

        public ResponseUsuarioCon ConsultarUsuario(RequestUsuarioCon Request)
        {
            if (Request == null)
            {
                AddNotification("Consultar", Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("ConsultarUsuario"));
                return null;
            }

            return (ResponseUsuarioCon)_db.Usuarios.Select(n => n.Nome).FirstOrDefault();

        }

        public Usuarios UConsultarUsuario(RequestUsuarioCon Request)
        {
          
            if (Request == null)
            {
                AddNotification("Consultar", Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("ConsultarUsuario"));
                return null;
            }

                return _db.Usuarios.FirstOrDefault(p => p.CodigoUsuario == Request.CodigoUsuario);
        }

        public List<Usuarios> UConsultarUsuario(Usuarios Request)
        {
            if (Request == null)
            {
                AddNotification("Consultar", Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("UConsultarUsuario"));
                return null;
            }

            var retorno = _db.Usuarios.Where(p => p.CodigoUsuario == Request.CodigoUsuario);

            return retorno.ToList();
        }

        List<Usuarios> IRepositoryUsuario.UConsultarUsuario(RequestUsuarioCon Request)
        {
            if (Request == null)
            {
                AddNotification("Consultar", Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("UConsultarUsuario"));
                return null;
            }

            var retorno = _db.Usuarios.Where(p => p.CodigoUsuario == Request.CodigoUsuario);

            return retorno.ToList();
        }
    }
}
