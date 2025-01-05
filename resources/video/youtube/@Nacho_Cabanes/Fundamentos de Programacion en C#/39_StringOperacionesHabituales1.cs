//! 039 - OPERADORES HABITUALES CON "STRING" (1: SUBCADENAS, BUSQUEDAS)

using System;

class EjemploDeStrings
{
    static void Main()
    {
        /* REPASO:
        string saludo = "Hola";

        foreach (char i in saludo)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine(saludo.ToUpper());

        saludo = saludo.ToUpper();
        Console.WriteLine(saludo);

        Console.WriteLine(saludo.Substring(1));
        Console.WriteLine(saludo.Substring(1,2));

        string texto2 = "ejemplo de texto de prueba";
        Console.WriteLine(texto2.Contains("de"));
        Console.WriteLine(texto2.IndexOf("de"));
        Console.WriteLine(texto2.IndexOf("de",10));
        Console.WriteLine(texto2.IndexOf("Nacho"));
        Console.WriteLine(texto2.IndexOf("de",10));
        */

        // TODO: EJERCICIO PROPUESTO
        //? Pide al usuario que introduzca una frase y:
        //* Muestra la frase en minusculas
        //* Di su longitud y su primera letra.
        //* Muestra la subcadena formada por las tres ultimas letras.
        //* Indica si contiene "yo".

        Console.Write("Dime una frase: ");
        string txt = Console.ReadLine();
        Console.WriteLine(txt.ToLower());
        Console.WriteLine(txt.Length);
        Console.WriteLine(txt[0]);
        Console.WriteLine(txt.Substring(txt.Length - 3));
        Console.WriteLine(txt.Contains("yo"));
    }
}