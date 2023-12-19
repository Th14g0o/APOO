using Projeto.Models;
using Projeto.Servico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Controllers
{
    public class AluguelController : Controller
    {
        // GET: Aluguel
        AluguelServico Servicos = new AluguelServico();

        public ActionResult Index()
        {
            return View(Servicos.Listar());
        }
        public ActionResult Gravar()
        {
            return View(new Aluguel());
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
            Aluguel a = Servicos.AcharPorId(id);
            bool exito = Servicos.Excluir(a);
            if (exito)
            {
                TempData["Message"] = "O ALUGUEL " + a.DataFesta.ToString("dd/MM/yyyy") + " FOI REMOVIDO";
            }
            else
            {
                TempData["Message"] = "O ALUGUEL " + a.DataFesta.ToString("dd/MM/yyyy") + " NÂO FOI REMOVIDO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Gravar(Aluguel a, long? id, string valor)
        {
            id = 0;
            DateTime DiaAlugado = DateTime.Now;
            bool converterParaNumero = double.TryParse(valor, NumberStyles.Float, CultureInfo.InvariantCulture, out double v);
            if (!converterParaNumero)
                return RedirectToAction("Index");

            a.Valor = v;
            bool exito = Servicos.Gravar(a, DiaAlugado, (long)id);
            if (exito)
            {
                TempData["Message"] = "O ALUGUEL " + a.DataFesta.ToString("dd/MM/yyyy") + " FOI CADASTRADO";
            }
            else
            {
                TempData["Message"] = "O ALUGUEL " + a.DataFesta.ToString("dd/MM/yyyy") + " NÂO FOI CADASTRADO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Editar(Aluguel a)
        {
            bool exito = Servicos.Editar(a);
            if (exito)
            {
                TempData["Message"] = "O ALUGUEL " + a.DataFesta.ToString("dd/MM/yyyy") + " FOI ATUALIZADO";
            }
            else
            {
                TempData["Message"] = "O ALUGUEL " + a.DataFesta.ToString("dd/MM/yyyy") + " NÂO FOI ATUALIZADO COM SUCESSO";
            }
            return RedirectToAction("Index");
        }
    }
}