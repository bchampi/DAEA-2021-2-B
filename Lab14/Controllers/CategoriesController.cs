using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Lab14.Controllers
{
    public class CategoriesController : Controller
    {
        #region Context
        private NorthwndEntities _context;

        public NorthwndEntities Context
        {
            set { _context = value; }
            get 
            {
                if (_context == null)
                    _context = new NorthwndEntities();
                
                return _context; 
            }
        }
        #endregion

        // GET: Categories
        public ActionResult Index()
        {
            return View(Context.Categories.ToList());
        }

        public ActionResult Create() // MOSTRAR FORMULARIO PARA CREAR CATEGORIA
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categories newCategory) // REGISTRAR CATEGORIA EN DB
        {
            try
            {
                if (ModelState.IsValid) // VALIDACION DE DATOS
                {
                    Context.Categories.Add(newCategory);
                    Context.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(newCategory);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int? id) // MOSTRAR FORMULARIO PARA EDITAR CATEGORIA
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            Categories editCategory = Context.Categories.Find(id);
            
            if (editCategory == null)
                return HttpNotFound();
            
            return View(editCategory);

        }

        [HttpPost]
        public ActionResult Edit(Categories editCategory) // REGISTRAR CAMBIOS DE LA CATEGORIA EN DB
        {
            try
            {
                if (ModelState.IsValid) // VALIDACION DE DATOS
                {
                    Context.Entry(editCategory).State = EntityState.Modified;
                    Context.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(editCategory);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int? id) // MOSTRAR FORMULARIO PARA ELIMINAR CATEGORIA
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Categories deleteCategory = Context.Categories.Find(id);

            if (deleteCategory == null)
                return HttpNotFound();

            return View(deleteCategory);
        }

        [HttpPost]
        public ActionResult Delete(int? id, Categories category) // ELIMINAR REGISTRO DE LA CATEGORIA EN DB
        {
            try
            {
                Categories deleteCategory = new Categories();
                if (ModelState.IsValid) // VALIDACION DE DATOS
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    deleteCategory = Context.Categories.Find(id);

                    if (deleteCategory == null)
                        return HttpNotFound();

                    Context.Categories.Remove(deleteCategory);
                    Context.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(deleteCategory);
            }
            catch
            {
                return View();
            }
        }
    }
}