//! 052 - ARRAY DE STRUCT + FUNCIONES: LIBRO

/* FUNCIONALIDADES QUE TENIAMOS
* Menu principal
* Anadir un nuevo dato
* Ver todos lo datos existentes
* Buscar por texto
* Modificar un dato
* Borrar un dato
* Ordenar
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
            Console.WriteLine((i + 1) + ": " + libros[i].autor + " - " + libros[i].titulo + " - " + libros[i].paginas + " - " + libros[i].ubicacion);

            if (i % 20 == 19)
            {
                Console.WriteLine("Pulse una tecla para continuar");
                Console.ReadLine();
            }
        }
    }

    static void Buscar()
    {
        Console.Write("Que texto quieres buscar?: ");
        string texto = Console.ReadLine();
        bool encontrado = false;
        for (int i = 0; i < cantidad; i++ )
        {
            if (libros[i].autor.ToUpper().Contains(texto.ToUpper()) 
                || libros[i].titulo.ToUpper().Contains(texto.ToUpper()) 
                || libros[i].ubicacion.ToUpper().Contains(texto.ToUpper()))
            {
                Console.WriteLine((i + 1) + ": " 
                    + libros[i].autor + " - " 
                    + libros[i].titulo + " - " 
                    + libros[i].paginas + " - " 
                    + libros[i].ubicacion);
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

        if (posicAModificar >=  cantidad)
        {
            Console.WriteLine("No hay tantos libros");
        }
        else 
        {
            Console.WriteLine("Dime el autor (era {0}): ", libros[posicAModificar].autor);
            string respuesta = Console.ReadLine();
            if (respuesta != "")
            {
                libros[posicAModificar].autor = respuesta;
            }

            Console.WriteLine("Dime el titulo (era {0}): ", libros[posicAModificar].titulo);
            respuesta = Console.ReadLine();
            if (respuesta != "")
            {
                libros[posicAModificar].titulo = respuesta;
            }

            Console.WriteLine("Dime paginas (era {0}): ", libros[posicAModificar].paginas);
            respuesta = Console.ReadLine();
            if (respuesta != "")
            {
                libros[posicAModificar].paginas = Convert.ToInt32(respuesta);
            }

            Console.WriteLine("Dime la ubicacion (era {0}): ", libros[posicAModificar].ubicacion);
            respuesta = Console.ReadLine();
            if (respuesta != "")
            {
                libros[posicAModificar].ubicacion = respuesta;
            }
        }
    }

    static void Borrar(){
        Console.WriteLine("Dime el numero de libros a borrar: ");
        int posicABorrar = Convert.ToInt32(Console.ReadLine()) - 1;

        if (posicABorrar >=  cantidad)
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
