using Rotativa;
using System.Web.Mvc;

namespace Rotativo_exemplo.Controllers
{
    public class PdfController : Controller
    {
        // GET: Pdf
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PDFPadrao2A()
        {
            return View("Modelo");
        }

        public ActionResult PDFPadrao()
        {
            string customSwitches = string.Format("--header-center  \"COMO USAR O ROTATIVA\" " +
                        "--header-spacing \"8\" " +
                        "--header-font-name \"Open Sans\" " +
                        "--footer-font-size \"8\" " +
                        "--footer-font-name \"Open Sans\" " +
                        "--header-font-size \"10\" "  +
                        "--footer-right \"Pag: [page] de [toPage]\"");

            var pdf = new ViewAsPdf
            {
                ViewName = "Modelo",
                 CustomSwitches = customSwitches,
                PageMargins = new Rotativa.Options.Margins(30, 10, 15, 10)
            };
            return pdf;
        }
    }
}