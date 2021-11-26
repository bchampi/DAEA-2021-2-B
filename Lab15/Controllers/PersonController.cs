using Lab15.Models;
using System;
using Microsoft.Reporting.WebForms;
using System.IO;
using System.Web.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace Lab15.Controllers
{
    public class PersonController : Controller
    {
        #region Context
        private SchoolEntities _context;

        public SchoolEntities Context
        {
            set { _context = value; }
            get
            {
                if (_context == null)
                    _context = new SchoolEntities();

                return _context;
            }
        }
        #endregion

        // GET: Person
        public ActionResult Index()
        {
            return View(Context.Person.ToList());
        }

        public ActionResult Report()
        {
            //  _ = new List<Person>();
            List<Person> list = Context.Person.ToList();

            var rptViewer = new ReportViewer();
            rptViewer.ProcessingMode = ProcessingMode.Local;
            rptViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Report.rdlc";

            ReportDataSource reportDataSource = new ReportDataSource("dsPerson", list);
            rptViewer.LocalReport.DataSources.Add(reportDataSource);
            rptViewer.SizeToReportContent = true;

            ViewBag.ReportViewer = rptViewer;
            return View();
        }

        [HttpPost]
        public ActionResult Report(string firstName)
        {
            List<Person> list = new List<Person>();
            // List<Person> list = Context.Person.ToList();
            list = (from p in Context.Person
                    where p.FirstName.Contains(firstName)
                    select p).ToList();
            var rptViewer = new ReportViewer();
            rptViewer.ProcessingMode = ProcessingMode.Local;
            rptViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Report.rdlc";

            ReportDataSource reportDataSource = new ReportDataSource("dsPerson", list);
            rptViewer.LocalReport.DataSources.Add(reportDataSource);
            rptViewer.SizeToReportContent = true;

            ViewBag.ReportViewer = rptViewer;
            return View();
        }
    }
}