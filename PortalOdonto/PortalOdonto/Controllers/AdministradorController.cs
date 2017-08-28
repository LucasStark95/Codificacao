using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;
namespace PortalOdonto.Controllers
{
    public class AdministradorController : Controller
    {
        
        private GerenciadorUsuario usuarioGerenciador;
        // GET: Usuario
        public AdministradorController()
        {           
            usuarioGerenciador = new GerenciadorUsuario();
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(FormCollection dadosForm, int tipo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    switch (tipo)
                    {
                        case 1:                            
                             Professor p = new Professor();
                             TryUpdateModel<Professor>(p, dadosForm.ToValueProvider());
                             break;
                            
                        case 2:
                            Aluno a = new Aluno();
                            TryUpdateModel<Aluno>(a, dadosForm.ToValueProvider());
                            break;
                        case 3:
                            Tecnico t = new Tecnico();
                            TryUpdateModel<Tecnico>(t, dadosForm.ToValueProvider());
                            break;
                    }
                    
                    
                   
                    
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                //implementar uma menssagem de erro
            }
            return View();
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
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
