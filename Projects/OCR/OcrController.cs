using Microsoft.AspNetCore.Mvc;
using System.IO;
using Tesseract;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OcrController : ControllerBase
    {
        [HttpPost("extract-text")]
        public IActionResult ExtractTextFromImage([FromForm] string imagePath)
        {
            try
            {
                // Inicializa el motor de Tesseract
                using var engine = new TesseractEngine(@"C:\tessdata", "eng");
                // Carga la imagen desde el archivo
                using var image = Pix.LoadFromFile(imagePath);
                // Procesa la imagen para extraer el texto
                using var page = engine.Process(image);

                var text = page.GetText();

                // Guarda el texto extraído en un archivo
                var outputPath = @"C:\output.txt";
                File.WriteAllText(outputPath, text);

                return Ok(new { Text = text, OutputPath = outputPath });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }
    }
}

