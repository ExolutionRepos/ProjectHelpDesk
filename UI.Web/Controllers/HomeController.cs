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
            
            return View(_RepositoryUsuario.List().Where(a => a.Nome == "Rogério Guimarae Da ilva Júnior"));
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

        public ActionResult View1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}