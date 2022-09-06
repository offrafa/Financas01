using Financas01.DAO;
using Financas01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Financas01.Controllers
{
    public class MovimentacaoController : Controller
    {
        private MovimentacaoDAO movimentacaoDAO;
        private UsuarioDAO UsuarioDAO;

        public MovimentacaoController(MovimentacaoDAO movimentacaoDAO, UsuarioDAO usuarioDAO)
        {
            this.movimentacaoDAO = movimentacaoDAO;
            this.UsuarioDAO = usuarioDAO;
        }



         // GET: Movimentacao
        public ActionResult form()
        {
            ViewBag.Usuarios = UsuarioDAO.Lista();

            return View();
        }
        public ActionResult Adiciona(Movimentacao movimentacao)
        {
            if (ModelState.IsValid)
            {
                movimentacaoDAO.Adiciona(movimentacao);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Usuarios = UsuarioDAO.Lista();
                return View("Form", movimentacao);
            }
        }
        public ActionResult Index()
        {
            IList<Movimentacao> movimentacaos = movimentacaoDAO.Lista();
            return View(movimentacaos);
        }
    }
}