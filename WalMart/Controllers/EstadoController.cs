using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Walmart.Repositorios;
using DataAccessLayer;
using System.Configuration;
using Walmart.Entidades;
using Walmart.Cadastro;

namespace Walmart.Controllers
{
    public class EstadoController : Controller
    {
        //
        // GET: /Estados/

        public ActionResult Index()
        {
            var cadastro = new CadastroEstado();
            var model = cadastro.Lista();

            return View(model);
        }

        //
        // GET: /Estados/Details/5

        public ActionResult Details(int id)
        {
            var cadastro = new CadastroEstado();
            return View(cadastro.Seleciona(id));
        }

        //
        // GET: /Estados/Create

        public ActionResult Create()
        {
            return View(new Estado());
        }

        //
        // POST: /Estados/Create

        [HttpPost]
        public ActionResult Create(Estado newEstado)
        {

            if (ModelState.IsValid)
            {
                var cadastro = new CadastroEstado();
                cadastro.Adiciona(newEstado);
                return RedirectToAction("index");
            }
            else
                return View(newEstado);
        }

        //
        // GET: /Estados/Edit/5

        public ActionResult Edit(int id)
        {
            var cadastro = new CadastroEstado();
            return View(cadastro.Seleciona(id));
        }

        //
        // POST: /Estados/Edit/5

        [HttpPost]
        public ActionResult Edit(Estado estadoAntigo)
        {

            if (ModelState.IsValid)
            {
                var cadastro = new CadastroEstado();
                cadastro.Atualiza(estadoAntigo);
                return RedirectToAction("Index");
            }
            else
                return View(estadoAntigo);
            
        }

        //
        // GET: /Estados/Delete/5

        public ActionResult Delete(int id)
        {
            var cadastro = new CadastroEstado();
            return View(cadastro.Seleciona(id));
        }

        //
        // POST: /Estados/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var cadastro = new CadastroEstado();
            cadastro.Deleta(id);
            return RedirectToAction("Index");
        }
    }
}
