using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Lab14.Controllers
{
    public class ProductsController : Controller
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

        // GET: Products
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var productByCategory = from p in Context.Products
                                    orderby p.ProductName ascending
                                    where p.CategoryID == id
                                    select p;

            if (productByCategory == null)
                return HttpNotFound();

            return View(productByCategory.ToList());
        }
    }
}