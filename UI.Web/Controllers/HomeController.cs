using Library.Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Business.Interfaces.Services;

namespace UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BaseService<Usuarios> _RepositoryUsuario;

        public HomeController()
        {
            _RepositoryUsuario = new BaseService<Usuarios>();
        }

        [HttpPost]
        public ActionResult suaAction(Library.Class.Models.Usuarios usuarios)
        {

            return null;
        }

        public ActionResult Index()
        {
            return RedirectToAction("Login");
            //return View();
            //_RepositoryUsuario.List().Where(a => a.Nome == "Rogério Guimarae Da ilva Júnior")
        }

        public ActionResult Registro(string _usuario)
        {
            if (ModelState.IsValid)
            {
            }
            return View(_usuario);
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

            return View(_RepositoryUsuario.List().ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuarios u)
        {
            // esta action trata o post (login)
            if (ModelState.IsValid) //verifica se é válido
            {


            }
            return View(_RepositoryUsuario.List().FirstOrDefault<Usuarios>());
        }





        public ActionResult View1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registrar(Usuarios usuarios)
        {

            //usuarios
            return View();
        }


    }
}