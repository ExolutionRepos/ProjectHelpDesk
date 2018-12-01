using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Web.Controllers
{
    public class WindowsController : Controller
    {
        // GET: Windows
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Principal()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult Pre_Chamado()
        {
            return View();
        }
        public ActionResult Conclusao()
        {
            return View();
        }
        public ActionResult Acompanhe()
        {
            return View();
        }
    }
}