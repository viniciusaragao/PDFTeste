using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpertPdf.HtmlToPdf;

namespace TestePDF.Controllers
{
    public class HomeController : Controller
    {
        public FileResult Index()
        {
            PdfConverter pdf = new PdfConverter();
            byte[] bytes = pdf.GetPdfBytesFromUrl("http://localhost:53559/ModelosDeProposta/");

            return File(bytes, "application/pdf", "arquivo.pdf");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
