//! 040 - OPERACIONES HABITUALES CON "STRING" (2: INSERTAR, ELIMINAR, REEMPLAZAR, PARTIR)

using System;
using System.Runtime.InteropServices.Marshalling;

class EjemploDeStrings
{
    static void Main()
    {
        /* REPASO:
        string texto2 = "ejemplo de texto de prueba";
        Console.WriteLine(texto2);
        
        Console.WriteLine( texto2.Replace("a", "-1-"));
        Console.WriteLine(texto2.Insert(1, "123"));
        Console.WriteLine(texto2.Remove(2, 3));

        string[] trozos = texto2.Split();
        foreach (string s in trozos)
            Console.WriteLine(s);
        string[] trozo2 = texto2.Split('-');
        char[] delimitadores = {'.', ',', '-', ' '};
        string[] trozo3 = texto2.Split(delimitadores);

        string cadenaModificada = string.Join('-', trozos);
        Console.WriteLine(cadenaModificada);
        */

        //TODO: EJERCICIO PROPUESTO
        //* Pide al usuario que introduzca una frase y:

        //? Muestre el resultado de cambiar las "o" por "e".
        //? Inserta "Hola" en la tercera posicion.
        //? Borra sus dos ultimas letras.
        //? Si esta formada por varias palabras, muestra la segunda de ellas.

        Console.WriteLine("Introduce una frase: ");
        string frase = Console.ReadLine();

        Console.WriteLine(frase.Replace("o", "e"));
        Console.WriteLine(frase.Insert(2, "hola"));
        Console.WriteLine(frase.Remove(frase.Length - 2, 2));
        Console.WriteLine(frase.Split()[1]);
    }
}