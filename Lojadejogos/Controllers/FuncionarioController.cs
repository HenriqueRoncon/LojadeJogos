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
    public class FuncionarioController : Controller
    {
        public ActionResult Funcionario()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        
        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Funcionario(Funcionario fun)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarFuncionario(fun);
                    return RedirectToAction("ListarFuncionario");
                }

                return View(fun);
            }
            catch
            {
                return View("ListarFuncionario");
            }
        }

        public ActionResult ListarFuncionario()
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);
        }
    }
}