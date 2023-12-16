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
        public ActionResult Ver(long id)
        {

            return View(Servicos.AcharPorId(id));
        }
        public ActionResult Editar(long id)
        {
            return View(Servicos.AcharPorId(id));
        }
        [HttpPost]
        public ActionResult Excluir(long id)
        {
            ItemTema i = Servicos.AcharPorId(id);
            bool exito = Servicos.Excluir(i);
            if (exito)
            {
                TempData["Message"] = "O ITEM " + i.nome.ToUpper() + " FOI REMOVIDO";
            }
            else
            {
                TempData["Message"] = "O ITEM " + i.nome.ToUpper() + " NÂO FOI REMOVIDO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Gravar(ItemTema i )
        {
            bool exito = Servicos.Gravar(i);
            if (exito)
            {
                TempData["Message"] = "O ITEM " + i.nome.ToUpper() + " FOI CADSTRADO";
            }
            else
            {
                TempData["Message"] = "O ITEM " + i.nome.ToUpper() + " NÂO FOI CADSTRADO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Editar(ItemTema i)
        {
            bool exito = Servicos.Editar(i);
            if (exito)
            {
                TempData["Message"] = "O ITEM " + i.nome.ToUpper() + " FOI EDITADO";
            }
            else
            {
                TempData["Message"] = "O ITEM " + i.nome.ToUpper() + " NÂO FOI EDITADO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
    }
}