using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TareasGant.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaController : ControllerBase
    {
        [HttpPost("upload-lista")]
        public async Task<IActionResult> ProcesarListasJson(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Archivo no proporcionado o vacío.");

            using (var LectorFile = new StreamReader(file.OpenReadStream()))
            {
                var ContenidoJson = await LectorFile.ReadToEndAsync();
                var listasJson = JsonConvert.DeserializeObject<List<ListaJson>>(ContenidoJson);

                if (listasJson == null || !listasJson.Any())
                    return BadRequest("El archivo no contiene listas válidas.");

                var listasPorId = listasJson.ToDictionary(lista => lista.Id);
                var padres = new List<ListaJson>();

                // Paso 1: Identificar padres e hijos (niveles)
                foreach (var lista in listasJson)
                {
                    if (lista.Padre == null)
                    {
                        padres.Add(lista);
                    }
                    else if (listasPorId.TryGetValue((int)lista.Padre, out var padre))
                    {
                        padre.Hijo.Add(lista);
                    }
                }

                // Paso 2: Ordenar hijos
                foreach (var padre in padres)
                {
                    OrdenarHijosPorFecha(padre.Hijo);
                }

                // Paso 3: Comparar fechas de cada hijo con su padre
                foreach (var padre in padres)
                {
                    CompararFechasDelPadre(padre);
                }

                // Paso 4: Agrupar por nivel
                var tareasAgrupadasPorNivel = AgruparElementosPorNivel(listasJson);

                return Ok(tareasAgrupadasPorNivel); // Devolver agrupado por nivel
            }
        }

        private void OrdenarHijosPorFecha(List<ListaJson> hijos)
        {
            hijos.Sort((hijo1, hijo2) => DateTime.Parse(hijo1.FechaInicio).CompareTo(DateTime.Parse(hijo2.FechaInicio)));
        }

        private void CompararFechasDelPadre(ListaJson padre)
        {
            padre.FechaInicio = padre.Hijo.Any() ? padre.Hijo.Min(hijo => hijo.FechaInicio) : padre.FechaInicio;
            padre.FechaFin = padre.Hijo.Any() ? padre.Hijo.Max(hijo => hijo.FechaFin) : padre.FechaFin;

            foreach (var hijo in padre.Hijo)
            {
                if (DateTime.Parse(hijo.FechaInicio) < DateTime.Parse(padre.FechaInicio))
                {
                    padre.FechaInicio = hijo.FechaInicio;
                }

                if (DateTime.Parse(hijo.FechaFin) > DateTime.Parse(padre.FechaFin))
                {
                    padre.FechaFin = hijo.FechaFin;
                }

                if (hijo.Hijo.Any())
                {
                    CompararFechasDelPadre(hijo); 
                }
            }
        }

        public static Dictionary<int, List<ListaJson>> AgruparElementosPorNivel(List<ListaJson> elementos)
        {
            var elementosPorNivel = new Dictionary<int, List<ListaJson>>();

            foreach (var elemento in elementos)
            {
                int nivel = CalcularNivel(elemento, elementos);
                if (!elementosPorNivel.ContainsKey(nivel))
                {
                    elementosPorNivel[nivel] = new List<ListaJson>();
                }
                elementosPorNivel[nivel].Add(elemento);
            }

            return elementosPorNivel;
        }

        public static int CalcularNivel(ListaJson elemento, List<ListaJson> elementos)
        {
            int nivel = 0;
            var actual = elemento;
            while (actual.Padre != null)
            {
                actual = elementos.FirstOrDefault(e => e.Id == actual.Padre);
                nivel++;
            }
            return nivel;
        }

        public static int ObtenerNivel(ListaJson elemento, List<ListaJson> elementos)
        {
            if (elemento.Padre == null)
            {
                return 1;
            }

            var padre = elementos.FirstOrDefault(e => e.Id == elemento.Padre);
            return 1 + ObtenerNivel(padre, elementos);
        }
    }
}
