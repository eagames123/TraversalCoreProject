using System.Collections.Generic;
using BusinessLayer.Abstract;
using OfficeOpenXml;

namespace BusinessLayer.Concrete
{
    public class ExcelManager : IExcelService
    {
        public byte[] ExcelList<T>(List<T> t) where T : class
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var worksheet = excelPackage.Workbook.Worksheets.Add("Sayfa1");
            worksheet.Cells["A1"].LoadFromCollection(t, true, OfficeOpenXml.Table.TableStyles.Dark1);
            return excelPackage.GetAsByteArray();
        }
    }
}
