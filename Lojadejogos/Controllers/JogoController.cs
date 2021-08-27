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
        public ActionResult CadastrodeJogos()
        {
            return View();
        }
        [HttpPost]



        public ActionResult CadastrodeJogos(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoJogo", jogo);
            }
            return View(jogo);
        }



        public ActionResult ResultadoJogo(Jogo jogo)
        {
            return View(jogo);
        }
    }
}