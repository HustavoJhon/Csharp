//! 053 - PARAMETROS O ARGUMENTOS? EVITA CODIGO REPETITIVO

/* PARAMETROS VS ARGUMENTOS
* Se suelen usar como sinonimos. Realmente no son los mismo:
* Se llama parametro a lo que se indica al definir la funcion: "int n" y "char letra" en void "DibujarLinea(int n, char letra)"
* Se llma argumento al valor que se pasa cuando se llama a la funcion: "3" y "-" en "DibujarLinea(3, '-')"
*/

/* EVITA CODIGO REPETITIVO
* Las funciones nos ayudan a simplificar problemas, descomponiendolos en subproblemas
* Algunas "pistas" de que  deberiamos descomponer:
    * Si una "zona" del programa sirve a una funcionalidad concreta
    * Si una "zona" del programa es "demasiado grande" (60 lineas = pagina impresa, 25 lineas = pantalla, 15 lineas segund algunos autores)
    * Si vemos "bloques repetitivos" en nuestro programa
*/

using System;

class GestionDeLibros
{
    struct libro
    {
        public string autor;
        public string titulo;
        public int paginas;
        public string ubicacion;
    }

    const int MAX = 1000;
    static int cantidad = 0;
    static libro[] libros;

    static void Main()
    {
        libros = new libro[MAX];
        string opcion;

        do
        {
            Console.WriteLine("Menú de libros:");
            Console.WriteLine("1. Anadir un nuevo libro");
            Console.WriteLine("2. Ver todos los libros");
            Console.WriteLine("3. Buscar por texto");
            Console.WriteLine("4. Modificar un libro");
            Console.WriteLine("5. Borrar un libro");
            Console.WriteLine("6. Ordenar");
            Console.WriteLine("S. Salir");

            opcion = Console.ReadLine().ToUpper();

            switch (opcion)
            {
                case "1": Agregar(); break;
                case "2": Ver(); break;
                case "3": Buscar(); break;
                case "4": Modificar(); break;
                case "5": Borrar(); break;
                case "6": Ordenar(); break;
                case "S": break; // Salir
                default: Console.WriteLine("Opción no valida"); break;
            }
        }
        while (opcion != "0" && opcion != "S");
        Console.WriteLine("Gracias por usar el programa");
    }


    static void Agregar()
    {
        if (cantidad < MAX)
        {
            Console.Write("Autor: ");
            libros[cantidad].autor = Console.ReadLine();

            Console.Write("Titulo: ");
            libros[cantidad].titulo = Console.ReadLine();

            Console.Write("Paginas?: ");
            libros[cantidad].paginas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ubicacion: ");
            libros[cantidad].ubicacion = Console.ReadLine();

            cantidad++;
        }
        else
        {
            Console.WriteLine("No caben mas datos");
        }
    }


    static void Ver()
    {
        for (int i = 0; i < cantidad; i++)
        {
            MostrarUnLibro(libros[i], i);
            if (i % 20 == 19)
            {
                Console.WriteLine("Pulse una tecla para continuar");
                Console.ReadLine();
            }
        }
    }

    static void MostrarUnLibro(libro l, int posicion)
    {
        Console.WriteLine((posicion + 1) + ": "
            + l.autor + " - "
            + l.titulo + " - "
            + l.paginas + " - "
            + l.ubicacion);
    }

    static void Buscar()
    {
        Console.Write("Que texto quieres buscar?: ");
        string texto = Console.ReadLine();
        bool encontrado = false;
        for (int i = 0; i < cantidad; i++)
        {
            if (libros[i].autor.ToUpper().Contains(texto.ToUpper())
                || libros[i].titulo.ToUpper().Contains(texto.ToUpper())
                || libros[i].ubicacion.ToUpper().Contains(texto.ToUpper()))
            {
                MostrarUnLibro(libros[i], i);
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("No se encontraron coincidencias");
        }
    }


    static void Modificar()
    {
        Console.WriteLine("Dime el numero de libro a editar: ");
        int posicAModificar = Convert.ToInt32(Console.ReadLine()) - 1;

        if (posicAModificar >= cantidad)
        {
            Console.WriteLine("No hay tantos libros");
        }
        else
        {
            libros[posicAModificar].autor = PedirParaModificar("Dime el autor", libros[posicAModificar].autor);

            libros[posicAModificar].titulo = PedirParaModificar("Dime el titulo", libros[posicAModificar].titulo);

            libros[posicAModificar].paginas = Convert.ToInt32(PedirParaModificar("Dime las paginas", libros[posicAModificar].paginas.ToString()));

            libros[posicAModificar].ubicacion = PedirParaModificar("Dime la ubicacion", libros[posicAModificar].ubicacion);

        }
    }


    static string PedirParaModificar(string aviso, string valorAnterior)
    {
        Console.Write(aviso + "(era " + valorAnterior + "):");
        string respuesta = Console.ReadLine();
        if (respuesta != "")
        {
            return respuesta;
        }
        else
        {
            return valorAnterior;
        }
    }

    static void Borrar()
    {
        Console.WriteLine("Dime el numero de libros a borrar: ");
        int posicABorrar = Convert.ToInt32(Console.ReadLine()) - 1;

        if (posicABorrar >= cantidad)
        {
            Console.WriteLine("No hay tantos libros");
        }
        else
        {
            for (int i = posicABorrar; i < cantidad - 1; i++)
            {
                libros[i] = libros[i + 1];
            }
            cantidad--;
        }
    }


    static void Ordenar()
    {
        for (int i = 0; i < cantidad - 1; i++)
        {
            for (int j = i + i + 1; j < cantidad; j++)
            {
                if (String.Compare(libros[i].titulo, libros[j].titulo, true) > 0)
                {
                    libro aux = libros[i];
                    libros[i] = libros[j];
                    libros[j] = aux;
                }
            }
        }
        Console.WriteLine("Libros ordenados");
    }
}

// TODO: EJERCICIO PROPUESTO 
// * Asegurate de que tu programa similar al gestor de libros, que habias descompuesto en funciones, no tiene (apenas) codigo repetitivo.