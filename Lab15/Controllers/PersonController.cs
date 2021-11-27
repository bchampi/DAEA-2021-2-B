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
using System.Collections;

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
            _ = new List<Person>();
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
        public ActionResult Report(string search)
        {
            List<Person> list = new List<Person>();
            list = (from p in Context.Person
                    where p.FirstName.Contains(search.ToUpper())
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

        public ActionResult Graphic()
        {
            return View();
        }

        public ActionResult GraphicColumn()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();

            var query = (from c in Context.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));
            
            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Gráfico de Columnas")
                .AddSeries("Default", chartType: "Column", xValue: x, yValues: y)
                .Write("bmp");

            return null;
        }

        public ActionResult GraphicBar()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();

            var query = (from c in Context.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));

            new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
                .AddTitle("Gráfico de Barras")
                .AddSeries("Default", chartType: "Bar", xValue: x, yValues: y)
                .Write("bmp");

            return null;
        }

        public ActionResult GraphicPie()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();

            var query = (from c in Context.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));

            new Chart(width: 600, height: 400, theme: ChartTheme.Blue)
                .AddTitle("Gráfico PIE")
                .AddSeries("Default", chartType: "Pie", xValue: x, yValues: y)
                .Write("bmp");

            return null;
        }

        public ActionResult GraphicRadar()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();

            var query = (from c in Context.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));

            new Chart(width: 600, height: 400, theme: ChartTheme.Yellow)
                .AddTitle("Gráfico de Radar")
                .AddSeries("Default", chartType: "Radar", xValue: x, yValues: y)
                .Write("bmp");

            return null;
        }
    }
}