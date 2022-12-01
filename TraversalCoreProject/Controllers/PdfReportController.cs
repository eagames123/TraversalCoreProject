using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Traversal Rezervasyon pdf raporu");
            document.Add(paragraph);
            document.Close();
            return File("/PdfReports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }

        public IActionResult TablePdfReportStatikCustomer()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            PdfPTable pdfTable = new PdfPTable(3);
            
            pdfTable.AddCell("Müşteri Adı");
            pdfTable.AddCell("Müşteri Soyadı");
            pdfTable.AddCell("Müşteri Tc");

            pdfTable.AddCell("Erkan");
            pdfTable.AddCell("Salihoğlu");
            pdfTable.AddCell("123456");

            pdfTable.AddCell("Arzu");
            pdfTable.AddCell("Salihoğlu");
            pdfTable.AddCell("444444");

            pdfTable.AddCell("Burak ");
            pdfTable.AddCell("Salihoğlu");
            pdfTable.AddCell("987654");

            document.Add(pdfTable);
            document.Close();
            return File("/PdfReports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }

    }
}
