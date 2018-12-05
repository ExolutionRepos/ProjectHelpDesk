using Library.Class.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Business.Interfaces.Repositories.Business;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class WindowsController : Controller
    {
        private readonly ControlChamado _RepositoryControlChamado;
        private readonly ControlProduto _RepositoryControlProduto;
        private readonly ControlTipoChamado _RepositoryControlTipoChamado;



        public WindowsController()
        {
            _RepositoryControlChamado = new ControlChamado();
            _RepositoryControlProduto = new ControlProduto();
            _RepositoryControlTipoChamado = new ControlTipoChamado();
        }



        // GET: Windows
        public ActionResult Acompanhe()
        {
            return View();
        }

        // GET: Windows
        public ActionResult Chamado(string Filtro = null)
        {
            var IdLogin = Convert.ToInt32(System.Web.HttpContext.Current.Session["IdLogin"]);
            var IdUsuario = Convert.ToInt32(System.Web.HttpContext.Current.Session["IdUsuario"]);

            if (IdLogin == 0 || IdUsuario == 0)
            {
                return RedirectToAction("Login", "Home");
            }

            var Data = _RepositoryControlChamado.PesquisarChamado();
            IQueryable<ClassGRID> a;

            if (Filtro != null)
            {
                a = _RepositoryControlChamado.PesquisarChamado()
                   .Where(y => y.CodigoUsuario_Cliente == IdUsuario
                  && ("00" + y.CodigoDepartamento.ToString() + "0" + y.CodigoTipoChamado.ToString() + "0000" + y.CodigoChamado.ToString()) == Filtro)
                    .Select(y => new ClassGRID
                    {
                        CodigoChamado = "00" + y.CodigoDepartamento.ToString() + "0" + y.CodigoTipoChamado.ToString() + "0000" + y.CodigoChamado.ToString(),
                        Descricao = y.Descricao,
                        Observacao = y.Observacao,
                        Status = y.Status,
                        DataFinalizacao = y.DataFinalizacao,
                    });

            }
            else
            {
                a = _RepositoryControlChamado.PesquisarChamado()
                  .Where(y => y.CodigoUsuario_Cliente == IdUsuario)
                   .Select(y => new ClassGRID
                   {
                       CodigoChamado = "00" + y.CodigoDepartamento.ToString() + "0" + y.CodigoTipoChamado.ToString() + "0000" + y.CodigoChamado.ToString(),
                       Descricao = y.Descricao,
                       Observacao = y.Observacao,
                       Status = y.Status,
                       DataFinalizacao = y.DataFinalizacao,
                   });

            }

            return View(a.ToList());
        }

        public ActionResult Conclusao()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            var Chamados = _RepositoryControlTipoChamado.PesquisarTipoChamado().ToList();
            ViewBag.Chamados = new SelectList(Chamados, "CodigoTipoChamado", "Nome");
            var Produto = _RepositoryControlProduto.PesquisarProduto().ToList();
            ViewBag.Produto = new SelectList(Produto, "CodigoProduto", "Nome");
            return View();
        }

        public ActionResult Pre_Chamado(string msg = null)
        {
            var Chamados = _RepositoryControlTipoChamado.PesquisarTipoChamado().ToList();
            ViewBag.Chamados = new SelectList(Chamados, "CodigoTipoChamado", "Nome");
            var Produto = _RepositoryControlProduto.PesquisarProduto().ToList();
            ViewBag.Produto = new SelectList(Produto, "CodigoProduto", "Nome");

            ViewBag.Msg = msg;

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
                var Observacao = Convert.ToString(collection["Observacao"]);
                var Produto = Convert.ToInt32(collection["Produto"]);
                var DataGarantia = Convert.ToString(collection["DataGarantia"]);
                var TipoChamado = Convert.ToInt32(collection["TipoChamado"]);

                var IdUsuario = Convert.ToInt32(System.Web.HttpContext.Current.Session["IdUsuario"]);

                var retorno = _RepositoryControlChamado.CadastrarChamado(
                    Descricao, Observacao, Library.Class.Enum.EnumStatusChamado.StatusChamado.PreChamado,
                    Library.Class.Enum.EnumChamado.ChamadoPrioridade.Media, TipoChamado, Produto, IdUsuario, 1, 0, DateTime.Today.Date);

                return RedirectToAction("Pre_Chamado", "Windows", new { @msg = retorno.Status ? "":"Erro" + retorno.Propert + " - " + retorno.Message });
            }
            catch
            {
                return RedirectToAction("Index");
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
