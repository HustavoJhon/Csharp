using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.IO;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EPPLUSController : ControllerBase
    {
        // Acción para generar y descargar un archivo Excel con formato de factura
        [HttpGet("download")]
        public IActionResult DownloadExcel()
        {
            // Configura el contexto de licencia de EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Añade una hoja de trabajo llamada "Factura"
                var worksheet = package.Workbook.Worksheets.Add("Factura");

                // Escribe los encabezados de la factura
                worksheet.Cells["A1"].Value = "Factura No.";
                worksheet.Cells["B1"].Value = "Fecha";
                worksheet.Cells["C1"].Value = "Cliente";
                worksheet.Cells["D1"].Value = "Monto";

                // Escribe datos de ejemplo en la hoja
                worksheet.Cells["A2"].Value = "12345";
                worksheet.Cells["B2"].Value = DateTime.Now.ToString("yyyy-MM-dd");
                worksheet.Cells["C2"].Value = "Juan Pérez";
                worksheet.Cells["D2"].Value = 1000;

                worksheet.Cells["A3"].Value = "67890";
                worksheet.Cells["B3"].Value = DateTime.Now.ToString("yyyy-MM-dd");
                worksheet.Cells["C3"].Value = "Ana López";
                worksheet.Cells["D3"].Value = 1500;

                worksheet.Cells["A4"].Value = "11223";
                worksheet.Cells["B4"].Value = DateTime.Now.ToString("yyyy-MM-dd");
                worksheet.Cells["C4"].Value = "Carlos García";
                worksheet.Cells["D4"].Value = 2000;

                // Aplica estilo a los encabezados
                worksheet.Cells["A1:D1"].Style.Font.Bold = true;
                worksheet.Cells["A1:D1"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                worksheet.Cells["A1:D1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                // Aplica borde alrededor de los datos
                worksheet.Cells["A1:D4"].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                // Formato de número para la columna de Monto
                worksheet.Cells["D2:D4"].Style.Numberformat.Format = "#,##0.00";

                // Formato de fecha para la columna de Fecha
                worksheet.Cells["B2:B4"].Style.Numberformat.Format = "yyyy-mm-dd";

                // Convierte el paquete de Excel en un flujo de memoria para la descarga
                var fileStream = new MemoryStream(package.GetAsByteArray());
                var fileName = "FacturaGenerada.xlsx";

                // Devuelve el archivo Excel como respuesta
                return File(fileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
        }
    }
}
