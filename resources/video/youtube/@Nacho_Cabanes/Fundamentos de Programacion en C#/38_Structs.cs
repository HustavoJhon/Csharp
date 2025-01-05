//! 038 - CONTACTO CON LOS "STRUCT"

/* STRUCTS (1)
* En espanol: registros"
struct persona
{
    public string nombre;
    public char inicial;
    public int edad;
    public float nota;
}
*/

/* STRUCTS (2)
* persona p1;
p1.nombre = "Cristian";
p1.inicial = 'C';
p1.edad = 22;
p1.nota = 9.5f;
*/

/* ARRAYS DE STRUCTS
* perona[] gente = new persona[100];
gente[0].nombre = "Cristian";
gente[0].inicial = 'C';
gente[0].edad = 22;
gente[0].nota = 9.5f;
*/

/* STRUCT ANIDADOS (1)
struct persona
{
    public string nombre;
    public fecha cumpleanos;
}
*persona1.cumpleanos.mes = 11;
*/

using System;

class EjemploDeStruct
{
    /*
    struct fecha
    {
        public int anyo;
        public int mes;
    }
    struct libro
    {
        public string autor;
        public string titulo;
        public int paginas;
        public bool esElectronico;
        public fecha fechaDePublicacion;
    }
    */
    struct Libro
    {
        public string titulo;
        public string autor;
        public int anio;
    }
    static void Main()
    {
        // libro l1, l2;
        /*
        int[] n = new int[50];

        libro[] libros = new libro[300];

        libros[0].autor = "Cervantes";
        libros[0].titulo = "El QUijote";

        libros[1].autor = "Stephern King";
        libros[1].titulo = "It 2019";
        libros[1].paginas = 500;
        libros[1].fechaDePublicacion.mes = 11; //struc anidado
        libros[1].fechaDePublicacion.anyo = 2019;
        */

        // TODO: EJERCICIO PROPUESTO
        //? Crear struct almacenar libros, que guarde (por ejemplo) el titulo, el autor y el anio de impresion. Crea un array que permita almacenar hasta 100 libros y un menu con el que el usuario pueda anotar un nuevo libro o ver todos los existentes.
        // Definimos un array para almacenar hasta 100 libros
        Libro[] libros = new Libro[100];
        int contadorLibros = 0; // Contador para llevar control de los libros ingresados

        int opcion;
        do
        {
            // Mostrar el menú al usuario
            Console.WriteLine("Menú de libros:");
            Console.WriteLine("1. Añadir un nuevo libro");
            Console.WriteLine("2. Ver todos los libros existentes");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Añadir un nuevo libro
                    if (contadorLibros < 100)
                    {
                        Libro nuevoLibro;

                        Console.Write("Introduce el título del libro: ");
                        nuevoLibro.titulo = Console.ReadLine();

                        Console.Write("Introduce el autor del libro: ");
                        nuevoLibro.autor = Console.ReadLine();

                        Console.Write("Introduce el año de impresión: ");
                        nuevoLibro.anio = Convert.ToInt32(Console.ReadLine());

                        // Guardar el nuevo libro en el array
                        libros[contadorLibros] = nuevoLibro;
                        contadorLibros++;
                        Console.WriteLine("Libro añadido con éxito.\n");
                    }
                    else
                    {
                        Console.WriteLine("La lista de libros está llena.\n");
                    }
                    break;

                case 2:
                    // Ver todos los libros existentes
                    if (contadorLibros > 0)
                    {
                        Console.WriteLine("\nLista de libros:");
                        for (int i = 0; i < contadorLibros; i++)
                        {
                            Console.WriteLine($"Libro {i + 1}:");
                            Console.WriteLine($"Título: {libros[i].titulo}");
                            Console.WriteLine($"Autor: {libros[i].autor}");
                            Console.WriteLine($"Año de impresión: {libros[i].anio}");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay libros en la lista.\n");
                    }
                    break;

                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.\n");
                    break;
            }

        } while (opcion != 3);
    }
}
