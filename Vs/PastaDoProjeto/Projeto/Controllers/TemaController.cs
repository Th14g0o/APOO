using Projeto.Models;
using Projeto.Servico;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Controllers
{
    public class TemaController : Controller
    {
        // GET: Tema
        TemaServico Servicos = new TemaServico();

        public ActionResult Index()
        {
            return View(Servicos.Listar());
        }
        public ActionResult Gravar()
        {
            return View(new Tema());
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
            Tema t = Servicos.AcharPorId(id);
            bool exito = Servicos.Excluir(t);
            if (exito)
            {
                TempData["Message"] = "O TEMA " + t.Nome.ToUpper() + " FOI REMOVIDO";
            }
            else
            {
                TempData["Message"] = "O TEMA " + t.Nome.ToUpper() + " NÂO FOI REMOVIDO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Gravar(Tema t, string valor)
        {
            bool converterParaNumero = double.TryParse(valor, NumberStyles.Float, CultureInfo.InvariantCulture, out double v);
            if (!converterParaNumero)
                return RedirectToAction("Index");

            t.ValorAluguel = v;
            bool exito = Servicos.Gravar(t);
            if (exito)
            {
                TempData["Message"] = "O TEMA " + t.Nome.ToUpper() + " FOI CADSTRADO";
            }
            else
            {
                TempData["Message"] = "O TEMA " + t.Nome.ToUpper() + " NÂO FOI CADSTRADO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Editar(Tema t, string valor)
        {
            if(valor.IndexOf(",") != -1)
                valor = valor.Replace(",", ".");
            bool converterParaNumero = double.TryParse(valor, NumberStyles.Float, CultureInfo.InvariantCulture, out double v);
            if (!converterParaNumero)
            {
                TempData["Message"] = "O TEMA " + t.Nome.ToUpper() + " NÂO FOI EDITADO COM SUCESSO";
                return RedirectToAction("Index");
            }
            t.ValorAluguel = v;
            bool exito = Servicos.Editar(t);
            if (exito)
            {
                TempData["Message"] = "O TEMA " + t.Nome.ToUpper() + " FOI EDITADO";
            }
            else
            {
                TempData["Message"] = "O TEMA " + t.Nome.ToUpper() + " NÂO FOI EDITADO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
    }
}