using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Business.Interfaces.Repositories.Business;

namespace UI.Web.Controllers
{
    public class WindowsController : Controller
    {
        private readonly ControlChamado _RepositoryControlLogin;
        private readonly ControlProduto _RepositoryControlProduto;


        public WindowsController()
        {
            _RepositoryControlLogin = new ControlChamado();
            _RepositoryControlProduto = new ControlProduto();
        }


        
        // GET: Windows
        public ActionResult Acompanhe()
        {
            return View();
        }

        // GET: Windows
        public ActionResult Chamado()
        {
            var IdLogin = Convert.ToInt32(System.Web.HttpContext.Current.Session["IdLogin"]);
            var IdUsuario = Convert.ToInt32(System.Web.HttpContext.Current.Session["IdUsuario"]);

            if (IdLogin == 0 || IdUsuario == 0)
            {
                return RedirectToAction("Login", "Home");
            }

            return View(_RepositoryControlLogin.PesquisarChamado().Where
                (y => y.CodigoUsuario_Cliente == IdUsuario)
                .ToList<Library.Class.Models.Chamados>()
                );
        }

        public ActionResult Conclusao()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult Pre_Chamado()
        {
            var Produto = _RepositoryControlProduto.PesquisarProduto().ToList();
            ViewBag.Produto = new SelectList(Produto, "CodigoProduto","Nome");
                
            return View();
        }

        // GET: Windows
        public ActionResult Index()
        {
            return View();
        }

        // GET: Windows/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Windows/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Windows/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {

                var Descricao = Convert.ToString(collection["Descricao"]);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Windows/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Windows/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Windows/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Windows/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
