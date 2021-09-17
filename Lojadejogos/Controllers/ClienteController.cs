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
    public class ClienteController : Controller
    {
        public ActionResult Cliente()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Cliente(Cliente cli)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarCliente(cli);
                    return RedirectToAction("ListarCliente");
                }

                return View(cli);
            }
            catch
            {
                return View("ListarCliente");
            }
        }

        public ActionResult ListarCliente()
        {
            var ExibirCli = new Acoes();
            var TodosFunc = ExibirCli.ListarCliente();
            return View(TodosFunc);
        }
    }
}