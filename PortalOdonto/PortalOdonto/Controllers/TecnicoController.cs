using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace PortalOdonto.Controllers
{
    public class TecnicoController : Controller
    {
        private GerenciadorTriagem triagem;

        public TecnicoController()
        {
            triagem = new GerenciadorTriagem();
        }
        
        // GET: Tecnico
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tecnico/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tecnico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tecnico/Create
        [HttpPost]
        public ActionResult Create(Triagem tria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    triagem.Adicionar(tria);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                //Tratamento de exceção para controladoras
            }
            return View();
        }

        // GET: Tecnico/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Te
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tecnico/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tecnico/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
