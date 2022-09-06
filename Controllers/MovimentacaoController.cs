using Financas01.DAO;
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
    }
}