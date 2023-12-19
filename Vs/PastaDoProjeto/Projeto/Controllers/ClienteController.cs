using Projeto.Models;
using Projeto.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        ClienteServico Servicos = new ClienteServico();

        public ActionResult Index()
        {
            return View(Servicos.Listar());
        }
        public ActionResult Gravar()
        {
            return View(new Cliente());
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
            Cliente c = Servicos.AcharPorId(id);
            bool exito = Servicos.Excluir(c);
            if (exito)
            {
                TempData["Message"] = "O CLIENTE " + c.Nome.ToUpper() + " FOI REMOVIDO";
            }
            else
            {
                TempData["Message"] = "O CLIENTE " + c.Nome.ToUpper() + " NÂO FOI REMOVIDO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Gravar(Cliente c )
        {
            bool exito = Servicos.Gravar(c);
            if (exito)
            {
                TempData["Message"] = "O CLIENTE " + c.Nome.ToUpper() + " FOI CADSTRADO";
            }
            else
            {
                TempData["Message"] = "O CLIENTE " + c.Nome.ToUpper() + " NÂO FOI CADSTRADO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Editar(Cliente c)
        {
            bool exito = Servicos.Editar(c);
            if (exito)
            {
                TempData["Message"] = "O CLIENTE " + c.Nome.ToUpper() + " FOI EDITADO";
            }
            else
            {
                TempData["Message"] = "O CLIENTE " + c.Nome.ToUpper() + " NÂO FOI EDITADO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
    }
}