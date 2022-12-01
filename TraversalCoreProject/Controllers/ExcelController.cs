using System.Collections.Generic;
using System.IO;
using System.Linq;
using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<DestinationModel> DestinationModelList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using var c = new Context();
            destinationModels = c.Destinations.Select(x => new DestinationModel()
            {
                City = x.City,
                DayNight = x.DayNight,
                Price = x.Price,
                Capacity = x.Capacity
            }).ToList();
            return destinationModels;

        }

        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationModelList()), "application/vnd.openxmlformat-officedocument.spreadsheetml.sheet", "dosya1.xlsx");

            //Lisans Hatasını geçmek için 
            //https://epplussoftware.com/developers/licenseexception
            //2. appSettings.json
            //{
            //{
            //    "EPPlus": {
            //        "ExcelPackage": {
            //            "LicenseContext": "Commercial" //The license context used
            //        }
            //    }
            //}
            //}

            //ExcelPackage excelPackage = new ExcelPackage();
            //var worksheet = excelPackage.Workbook.Worksheets.Add("Sayfa1");
            //worksheet.Cells[1, 1].Value = "Rota";
            //worksheet.Cells[1, 2].Value = "Rehber";
            //worksheet.Cells[1, 3].Value = "Kontenjan";

            //worksheet.Cells[2, 1].Value = "Batum Turu";
            //worksheet.Cells[2, 2].Value = "Erkan";
            //worksheet.Cells[2, 3].Value = "20";

            //worksheet.Cells[3, 1].Value = "Ankara";
            //worksheet.Cells[3, 2].Value = "Salih";
            //worksheet.Cells[3, 3].Value = "33";

            //var bytes = excelPackage.GetAsByteArray();

            //return File(bytes, "application/vnd.openxmlformat-officedocument.spreadsheetml.sheet", "dosya1.xlsx");
        }

        public IActionResult DestinationExcelReport()
        {
            using var workBook = new XLWorkbook();
            var workSheet = workBook.Worksheets.Add("TurListesi");
            workSheet.Cell(1, 1).Value = "Şehir";
            workSheet.Cell(1, 2).Value = "Konaklama Süresi";
            workSheet.Cell(1, 3).Value = "Fiyat";
            workSheet.Cell(1, 4).Value = "Kapasite";
            int rowCount = 2;
            foreach (var item in DestinationModelList())
            {
                workSheet.Cell(rowCount, 1).Value = item.City;
                workSheet.Cell(rowCount, 2).Value = item.DayNight;
                workSheet.Cell(rowCount, 3).Value = item.Price;
                workSheet.Cell(rowCount, 4).Value = item.Capacity;
                rowCount++;

            }
            using (var stream = new MemoryStream())
            {
                workBook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.openxmlformat-officedocument.spreadsheetml.sheet", "dosya2.xlsx");
            }
        }
    }
}
