using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab14.Controllers
{
    public class CategoriesController : Controller
    {
        #region Context
        private NorthwndEntities _context;

        public NorthwndEntities Context
        {
            get 
            {
                if (_context == null)
                {
                    _context = new NorthwndEntities();
                }
                return _context; 
            }
        }
        #endregion

        // GET: Categories
        public ActionResult Index()
        {
            return View(Context.Categories.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categories newCategory)
        {
            try
            {
                if (ModelState.IsValid)
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


    }
}