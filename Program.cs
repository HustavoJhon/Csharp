//! 027 - CONTACTO CON LAS CADENAS DE TEXTO

/* CADENAS DE TEXTO - MANEJO BASICO
string frase;
frase = "Como estas?";
Console.WriteLine("La frase es \"{0}\"", frase);
Console.WriteLine("Introduce tu nombre");
frase = Console.ReadLine();
Console.WriteLine("Ahora la frase es "+ frase);
*/

/* COMPARACION
* Se pueden comparar valores:
if (nombre == "Jhonny")...
*(pero ">" y "<" no se pueden usar directamente para ver cual "es mayor")

* Se pueden usar en Switch
*/

/* OTRAS POSIBILIDADES
* Extraer caracteres individuales
* Extraer fragmento ("subcadenas")
* Reemplazar unos fragmentos por otros
* "Partir" de forma automatica
* Convertir a mayusculas o minusculas
*/

using System;

class Cadena1
{
    static void Main()
    {
        string nombre;
        Console.WriteLine("Introduce tu nombre");
        nombre = Console.ReadLine();
        if (nombre == "Nacho")
        {
            Console.WriteLine("Hola Nacho");
        }
        else
        {
            Console.WriteLine("Hola desconocido");
        }

        //TODO: EJERCICIOS PROPUESTOS
        //? Crea un esqueleto basico de "Traductor de C# a Java": El usuario introduce una orden en C# y el programa le mostrara su equivalente en Java. Solo reconocera inicialmente 4 ordenes: "if", "While" y "for", que escribe igual en Java, ademas de Console.WriteLine (que sera "System.out.println"). Debe avisar si se introduce una orden no reconocida.
        Console.WriteLine("Introduce una orden");
        string orden = Console.ReadLine();
        if (orden == "if")
        {
            Console.WriteLine("if");
        }
        else if (orden == "while")
        {
            Console.WriteLine("while");
        }
        else if (orden == "for")
        {
            Console.WriteLine("for");
        }
        else if (orden == "Console.WriteLine")
        {
            Console.WriteLine("System.out.println");
        }
        else
        {
            Console.WriteLine("No reconozco esa orden");
        }
    }
}