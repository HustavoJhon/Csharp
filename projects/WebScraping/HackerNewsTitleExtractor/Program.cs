using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        // Configurar el WebDriver
        IWebDriver driver = new ChromeDriver();

        try
        {
            // Navegar a Hacker News
            driver.Navigate().GoToUrl("https://news.ycombinator.com/");

            // Encontrar el primer título (etiqueta <a> con clase 'titleline')
            var firstTitleElement = driver.FindElement(By.ClassName("titleline"));
            string firstTitle = firstTitleElement.Text;

            // Mostrar el título en la consola
            Console.WriteLine($"Primer título: {firstTitle}");
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("No se pudo encontrar el elemento solicitado.");
        }
        finally
        {
            // Cerrar el navegador
            driver.Quit();
        }
    }
}

