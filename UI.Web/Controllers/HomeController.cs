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
            return RedirectToAction("Chamados","Windows");
        }

        public ActionResult Registrar(FormCollection collection)
        {

            BaseReturn retorno = null;

            var Nome = Convert.ToString(collection["Nome"]);

            if (ModelState.IsValid)
            {
                //    retorno = _RepositoryControlUsuario.CadastrarUsuario(nome, datanascimento, email, cpf, sexo, telefone, celular
                //, rua, bairro, cep, cidade, numero, uf, complemento
                //, codigotipousuario, codigodepartamento);

            }

            return RedirectToAction("Register", retorno);
        }

     

        public ActionResult Register(Usuarios _usuarios = null)
        {
            List<EnumModel> enums = ((Sexo[])Enum.GetValues(typeof(Sexo))).Select(c => new EnumModel()  { Value = (int)c, Name = c.ToString() }).ToList();
            ViewBag.Sexo = new SelectList(enums, "Value", "Name");
   
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

        public ActionResult Registrar(Usuarios usuarios)
        {

            //usuarios
            return View();
        }

        public ActionResult Sair()
        {
            ViewBag.Message = "Obrigado por utilizar esta plataforma.";

            return View("");
        }
    }
}