using Lojadejogos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lojadejogos.Models;
using System.Collections.ObjectModel;

namespace Lojadejogos.Controllers
{
    public class JogoController : Controller
    {
        public ActionResult Jogo()
        {
            var jogo = new Jogo();
            return View(jogo);
        }

        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Jogo(Jogo jogo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarJogo(jogo);
                    return RedirectToAction("ListarJogo");
                }

                return View(jogo);
            }
            catch
            {
                return View("ListarJogo");
            }
        }

        public ActionResult ListarJogo()
        {
            var ExibirJogo = new Acoes();
            var TodosJogos = ExibirJogo.ListarJogo();
            return View(TodosJogos);
        }
    }
}