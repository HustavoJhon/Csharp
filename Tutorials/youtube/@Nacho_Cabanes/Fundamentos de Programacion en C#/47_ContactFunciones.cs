//! 047 - CONTACTO CON LAS FUNCIONES

/* POR QUE USAR FUNCIONES?
* Para dividir el programa en bloques, buscando mas legibilidad y modularidad:

static void Main()
{
    ComprobarAcceso();
    MostraMenu();
}
*/

/* APARIENCIA DE UNA FUNCION
? Por buenas practicas se usa las primeras letras en mayusculas
* similar a Main()
* El "bloque" llamado ComprobarAcceso podria ser:

static void ComprobarAcceso()
{
    Console.WriteLine("Introduce tu usuario");
    ...
}
*/

/* EL ORDEN NO IMPORTA
* En otros lenguajes, como C, puede ser necesario declarar la funcion antes de "main", para que "la conozca" (aunque hay alternativas relativamente complejas).
* En C# no es necesario, la funcion puede ir antes o despues de Main
*/

/* PARAMETROS
* Se pueden indicar detalles adicionales (parametros) en los parentesis:

static void EscribirNumeroReal(float n)
{
    Console.Write(n.ToStrig("#,###"));
}
*/

/* VARIOS PARAMETROS
* Si hay varios parametros, se debera indicar el tipo de datos para todos ellos:

static void EscribirSuma( int n1, int n2, int n3)
{
    Console.WriteLine(n1 + n2 + n3);
}
*/

/* PROCEDIMIENTOS?
* Las funciones que no devuelven un valor ("funciones void") a menudo se llaman "procedimientos" o "subrutinas".
*/

using System;
using System.Runtime.InteropServices;

class Funciones1
{
    // Una funcion MostrarMenu, que muestre varias opciones al usuario
    static void MostrarMenuPrincipal()
    {
        Console.WriteLine("--- Menu principal ---");
        Console.WriteLine();
        Console.WriteLine("1. Agregar datos");
        Console.WriteLine("2. Buscar");
        Console.WriteLine("3. Modificar");
        Console.WriteLine("4. Eliminar");
        Console.WriteLine("5. Listar");
        Console.WriteLine("6. Salir");
    }

    //Escribe un texto centrado, que se indicara como parametro. La funcion se debera llamar "EscribirTextoCentrado"
    static void Escribircentrados(string texto)
    {
        Console.Write(new string(' ', 40-texto.Length/2));
        Console.WriteLine(texto);
    }

    // una funcion "EscribirTextoSubrayado", que escriba el texto que se le indique como primer parametro, subrayado con un caracter que se detalle como segundo parametro
    static void EscribirTextoSubrayado(string texto, char caracter)
    {
        Console.WriteLine(texto);
        for (int i = 0; i < texto.Length; i++)
        {
            Console.Write(caracter);
        }
        Console.WriteLine();
    }

    //TODO: EJERCICIO PROPUESTO
    //? Crea un procedimiento (funcion "void") llamado "DibujarTriangulo", que mostrara un triangulo de asteriscos, alineados a la izquierda, con la anchura inicial que se indique como parametro, y cuya anchura disminuira en una unidad en cada nueva fila.
    static void DibujarTriangulo(int anchura)
    {
        for (int i = anchura; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        MostrarMenuPrincipal();
        Escribircentrados("Hola");
        EscribirTextoSubrayado("Esto es un ejemplo subrayado", '-');

        Console.WriteLine("Ingrese la anchura inicial del triangulo");
        int anchura = int.Parse(Console.ReadLine());
        DibujarTriangulo(anchura);
    }
}