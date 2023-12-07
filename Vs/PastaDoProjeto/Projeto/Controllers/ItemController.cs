using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Servico;


namespace Projeto.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        ItemServico Servicos = new ItemServico();

        public ActionResult Index()
        {
            return View(Servicos.Listar());
        }
        public ActionResult Gravar()
        {
            return View(new ItemTema());
        }
        [HttpPost]
        public ActionResult Gravar(ItemTema i )
        {
            Servicos.Gravar(i);
            return RedirectToAction("Index");
        }
    }
}