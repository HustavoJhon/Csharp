//! 041 - STRINGBUILDER

/* MODIFICAR LETRAS DE STRINGS (1)
* No se puede cambiar caracteres en una cadena
    texto[0] = 'M';  // Error de compilacion

* Se debe crear una nueva cadena:
    texto = 'M' + text.Substring(1);
*/

/* MODIFICAR LETRAS DE STRINGS (2)
* Alternativa: StringBuilder
    - StringBuilder cadenaModificable = new StringBuilder("Hola");
    - cadenaModificable[0] = 'M';
    - string miCadena = cadenaModificable.ToString();
*/

using System;
using System.Text;

class EjemploDeStringBuilder
{
    static void Main()
    {
        /* REPASO:
        string frase = "Hola";
        // frase[1] = 'a';
        string frase2 = 
            frase.Substring(0, 1) + 'a' + frase.Substring(2);
        Console.WriteLine(frase2);

        string frase3 = frase.Remove(1,1).Insert(1, "a");
        Console.WriteLine(frase3);

        StringBuilder b = new StringBuilder(frase);
        b[1] = 'a';
        Console.WriteLine(b);

        Console.WriteLine(b.ToString().ToUpper());
        */

        //TODO: EJERCICIO PROPUESTO
        //* Pide al usuario una frase y reemplaza cada espacio en blanco con un numero consecutivo del 1 al 9, para despues volver a empezar en 0, en caso de que haya mas de 10 espacios. Por ejemplo, si escribe "Hola, Que tal estas?", el texto de salida sera "Hola, 1 que2tal3estas?"
        Console.Write("Escribe una frase: ");
        string frase = Console.ReadLine();
        
        // Usando Substring, Remove e Insert
        int contador = 1;
        string nuevaFrase = frase;
        
        for (int i = 0; i < nuevaFrase.Length; i++)
        {
            if (nuevaFrase[i] == ' ')
            {
                nuevaFrase = nuevaFrase.Remove(i, 1).Insert(i, contador.ToString());
                contador = (contador < 9) ? contador + 1 : 0;
            }
        }
        
        Console.WriteLine("Frase modificada usando Substring/Insert: " + nuevaFrase);

        // Usando StringBuilder
        contador = 1;
        StringBuilder sb = new StringBuilder(frase);
        
        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] == ' ')
            {
                sb[i] = contador.ToString()[0];
                contador = (contador < 9) ? contador + 1 : 0;
            }
        }

        Console.WriteLine("Frase modificada usando StringBuilder: " + sb.ToString());
  
    }
}