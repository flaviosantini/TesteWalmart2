using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Walmart.Repositorios;
using System.Configuration;
using Walmart.Entidades;
using Walmart.Cadastro;

namespace Walmart.Controllers
{
    public class CidadeController : Controller
    {

        //
        // GET: /Cidade/

        public ActionResult Index()
        {
            var cadastro = new CadastroCidade();
            var model = cadastro.Lista();

            return View(model);
        }

        //
        // GET: /Cidade/Details/5

        public ActionResult Details(int id)
        {
            var cadastro = new CadastroCidade();
            return View(cadastro.Seleciona(id));
        }

        //
        // GET: /Cidade/Create

        public ActionResult Create()
        {
            var cadastroEstado = new CadastroEstado();
            ViewBag.ListaEstado = cadastroEstado.Lista();
            return View(new Cidade());
        }

        //
        // POST: /Cidade/Create

        [HttpPost]
        public ActionResult Create(Cidade newCidade)
        {
            if (ModelState.IsValid)
            {
                var cadastro = new CadastroCidade();
                cadastro.Adiciona(newCidade);
                return RedirectToAction("index");
            }
            else
                return View(newCidade);
        }

        //
        // GET: /Cidade/Edit/5

        public ActionResult Edit(int id)
        {
            var cadastroEstado = new CadastroEstado();
            ViewBag.ListaEstado = cadastroEstado.Lista();
            var cadastro = new CadastroCidade();
            return View(cadastro.Seleciona(id));
        }

        //
        // POST: /Cidade/Edit/5

        [HttpPost]
        public ActionResult Edit(Cidade cidadeAntiga)
        {
            if (ModelState.IsValid)
            {
                var cadastro = new CadastroCidade();
                cadastro.Atualiza(cidadeAntiga);
                return RedirectToAction("Index");
            }
            else
                return View(cidadeAntiga);
        }

        //
        // GET: /Cidade/Delete/5

        public ActionResult Delete(int id)
        {
            var cadastro = new CadastroCidade();
            return View(cadastro.Seleciona(id));
        }

        //
        // POST: /Cidade/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var cadastro = new CadastroCidade();
            cadastro.Deleta(id);
            return RedirectToAction("Index");
        }
    }
}
