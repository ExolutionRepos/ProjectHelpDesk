using Library.Class.Models;
using Library.Class.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using UI.Business.Interfaces.Repositories.Business;
using UI.Business.Interfaces.Services;
using static Library.Class.Enum.EnumerableClass;
using static Library.Class.Enum.EnumSexo;

namespace UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ControlUsuario _RepositoryControlUsuario;
        private readonly ControlLogin _RepositoryControlLogin;

        public HomeController()
        {
            _RepositoryControlUsuario = new ControlUsuario();
            _RepositoryControlLogin = new ControlLogin();
        }

        [HttpPost]
        public ActionResult suaAction(Library.Class.Models.Usuarios usuarios)
        {

            return null;
        }

        public ActionResult Index(string login = null)
        {

            if (ModelState.IsValid && System.Web.HttpContext.Current.Session["Usuario"] != null)
            {
                System.Web.HttpContext.Current.Session["Usuario"] = login;
            }
            else
                System.Web.HttpContext.Current.Session["Usuario"] = "";

            return View();
        }

        public ActionResult Filtrar(string Filtro)
        {
            return RedirectToAction("Chamado","Windows",new { @Filtro = Filtro });
        }

        public ActionResult Registrar(FormCollection collection)
        {

            BaseReturn retorno = null;

            var Nome = Convert.ToString(collection["Nome"]);
            var Email = Convert.ToString(collection["Email"]);
            var DataNascimento = Convert.ToDateTime(collection["DataNascimento"]);
            var CPF = Convert.ToString(collection["CPF"]);
            var Telefone = Convert.ToString(collection["Telefone"]);
            var Celular = Convert.ToString(collection["Celular"]);
            var Sexo = (Sexo)Enum.Parse(typeof(Sexo), Convert.ToString(collection["Sexo"]));
            var Rua = Convert.ToString(collection["Rua"]);
            var Bairro = Convert.ToString(collection["Bairro"]);
            var CEP = Convert.ToString(collection["CEP"]);
            var Cidade = Convert.ToString(collection["Cidade"]);
            var Numero = Convert.ToInt32(collection["Numero"]);
            var UF = Convert.ToString(collection["UF"]);
            var Complemento = Convert.ToString(collection["Complemento"]);
            var Usuario = Convert.ToString(collection["Usuario"]);
            var Senha = Convert.ToString(collection["Senha"]);



            if (ModelState.IsValid)
            {
                retorno = _RepositoryControlUsuario.CadastrarUsuarioLogin(Nome,DataNascimento,Email,CPF,Sexo,Telefone,Celular, Rua, Bairro, CEP, Cidade, Numero, UF, Complemento, 2,1, Usuario, Senha.ConvertToMD5());
                

                return RedirectToAction("Register", "Home", new { @msg = retorno.Status ? "" : "Erro" + retorno.Propert + " - " + retorno.Message });
            }

            return RedirectToAction("Register", retorno);
        }

     

        public ActionResult Register(Usuarios _usuarios = null,string msg = null)
        {
            List<EnumModel> enums = ((Sexo[])Enum.GetValues(typeof(Sexo))).Select(c => new EnumModel()  { Value = (int)c, Name = c.ToString() }).ToList();
            ViewBag.Sexo = new SelectList(enums, "Value", "Name");

            ViewBag.Msg = msg;
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login.";

            return View();
        }

        [HttpPost]
        public ActionResult Login(string Login, string Senha)
        {

            if (ModelState.IsValid)
            {
                var retorno = _RepositoryControlLogin.Autenticar(Login, Senha.ToString().ConvertToMD5());

                if (retorno != null)
                {
                    var usuario = _RepositoryControlUsuario.PesquisarUsuario(retorno);

                    System.Web.HttpContext.Current.Session["IdLogin"] = retorno.CodigoLogin;
                    System.Web.HttpContext.Current.Session["IdUsuario"] = usuario.CodigoUsuario;
                    System.Web.HttpContext.Current.Session["Usuario"] = "Olá " + usuario.Nome;

                    return RedirectToAction("Index", "Home", new { login = "Olá " + usuario.Nome });
                    //return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Erro = "Usuario / Senha não encontrados ";
                }
            }

            return RedirectToAction("Login");

        }



        public ActionResult View1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult Register()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ActionResult Sair()
        {
            ViewBag.Message = "Obrigado por utilizar esta plataforma.";

            return View("");
        }
    }
}