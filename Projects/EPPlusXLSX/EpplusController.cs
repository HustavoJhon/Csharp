using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EPPLUSController : ControllerBase
    {
        // Acción para agregar una fórmula a un archivo Excel
        [HttpGet("add-formula")]
        public IActionResult AddFormula()
        {
            // Configura el contexto de licencia de EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Define las rutas del archivo original y el archivo modificado
            var originalFilePath = @"C:\Users\husta\Downloads\Workbook1.xlsx";
            var newFilePath = @"C:\Users\husta\Downloads\AnotherWorkbook.xlsx";

            // Abre el archivo Excel, agrega la fórmula y guarda el nuevo archivo
            using (var package = new ExcelPackage(new FileInfo(originalFilePath)))
            {
                var worksheet = package.Workbook.Worksheets["Worksheet1"];
                worksheet.Cells["A3"].Formula = "SUM(A1:A2)"; // Agrega la fórmula en la celda A3

                var newFile = new FileInfo(newFilePath);
                package.SaveAs(newFile);
            }

            return Ok("Fórmula añadida y archivo guardado correctamente.");
        }

        // Acción para leer datos de un archivo Excel
        [HttpGet("read-excel")]
        public IActionResult ReadExcel()
        {
            // Configura el contexto de licencia de EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Ruta del archivo Excel a leer
            var filePath = @"C:\Users\husta\Downloads\Workbook1.xlsx";
            var data = new List<string>();

            // Abre el archivo Excel y lee los datos
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets["Worksheet1"];
                int rows = worksheet.Dimension.Rows;
                int columns = worksheet.Dimension.Columns;

                // Itera a través de las filas y columnas y agrega los datos no vacíos
                for (int row = 1; row <= rows; row++)
                {
                    for (int col = 1; col <= columns; col++)
                    {
                        var cellValue = worksheet.Cells[row, col].Text;
                        if (!string.IsNullOrWhiteSpace(cellValue))
                        {
                            data.Add(cellValue);
                        }
                    }
                }
            }

            return Ok(data);
        }

        // Acción para subir y procesar un archivo Excel
        [HttpPost("upload")]
        public async Task<IActionResult> UploadExcel(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No se proporcionó un archivo o el archivo está vacío.");

            var data = new List<string>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Procesa el archivo subido y lee los datos
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    int rows = worksheet.Dimension.Rows;
                    int columns = worksheet.Dimension.Columns;

                    // Itera a través de las filas y columnas y agrega solo los datos no vacíos
                    for (int row = 1; row <= rows; row++)
                    {
                        bool isRowEmpty = true;

                        for (int col = 1; col <= columns; col++)
                        {
                            var cellValue = worksheet.Cells[row, col].Text;
                            if (!string.IsNullOrWhiteSpace(cellValue))
                            {
                                data.Add(cellValue);
                                isRowEmpty = false;
                            }
                        }

                        // Si la fila está completamente vacía, omitirla
                        if (isRowEmpty)
                            continue;
                    }
                }
            }

            return Ok(data);
        }

        // Acción para generar y descargar un archivo Excel con formato de factura
        [HttpGet("download")]
        public IActionResult DownloadExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Factura");

                // Escribe encabezados de la factura
                worksheet.Cells["A1"].Value = "Factura No.";
                worksheet.Cells["B1"].Value = "Fecha";
                worksheet.Cells["C1"].Value = "Cliente";
                worksheet.Cells["D1"].Value = "Monto";

                // Escribe datos de ejemplo
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

                var fileStream = new MemoryStream(package.GetAsByteArray());
                var fileName = "FacturaGenerada.xlsx";

                return File(fileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
        }
    }
}
