//! 026 - CARACTERES: TIPO DE DATOS "CHAR" 

//* char letra;
//* letra = 'a';
//* letra = Convert.ToChar(Console.ReadLine());
//* Existem relacion de orden

/* EL CODIGO ASCII
    - int ascii = (int) 'a';
    - char letra = (char) 66;

? SECUENCIAS DE ESCAPE

* \a Alerta (pitido)
* \b Retroceder (borra el ultimo caracter)
* \f Salto de pagina
* \n Salto de linea
* \r Retorno de carro (va al principio de la linea)
* \t Tabulador (horizontal)
* \v Tabulador vertical
* \' Comilla simple
* \" Comilla doble
* \\ Barra invertida
* \0 Caracter nulo (NULL)

? SECUENCIAS DE ESCAPE (2)

* Para escribir comillas:
- Console. Write("\"Hola\"");
*En las rutas de fichero habria que duplicar cada barra invertida
- ruta = "C:\\Users\\hustavo\\Documents\\C#\\Main\\Main.csproj";

*Como alternativa: prefijo @
- ruta = @"C:\Users\hustavo\Documents\C#\Main\Main.csproj";
*/


using System;

class Caracteres 
{

    static void Main()
    {
        /*
        for (char c = 'a'; c <= 'z'; c++)
        {
            Console.Write(c);
        }
        Console.ReadLine();
        Console.Write("Introduce un simbolo: ");
        char l = Convert.ToChar(Console.ReadLine());
        if (l >= '0' && l <= '9')
        {
            Console.WriteLine("Es un digito");
        }
        else if (l == '.' || l == ',')
        {
            Console.WriteLine("Es un simbolo de puntuacion");
        }
        else
        {
            Console.WriteLine("No es un digito");
        }

        Console.WriteLine("Ejemplo 2");
        Console.WriteLine( (int) 'a' );
        Console.WriteLine( (char) 66 );

        for (byte b = 32; b <= 126; b++)
        {
            Console.Write((char) b);
        }
        Console.WriteLine();

        Console.WriteLine("\"1\" a entero: {0}",
            Convert.ToInt32("1"));
        Console.WriteLine("'1' a entero: {0}",
            Convert.ToInt32('1'));
        */
        // TODO: EJERCICIOS PROPUESTOS
        //? Pide al usuario dos letras mayusculas y muestra todas letras que hay entre ellas, ambas incluidas, de forma creciente(incluso si el usuario introduce primero la "mayor" letra y luego la "menor")
        Console.Write("Introduce una letra mayuscula mayor: ");
        char l1 = Convert.ToChar(Console.ReadLine());
        Console.Write("Introduce una letra mayuscula menor: ");
        char l2 = Convert.ToChar(Console.ReadLine());

        for (char c = l1; c <= l2; c++)
        {
            Console.Write(c);
        }
        Console.WriteLine();
        //? Pide un caracter al usuario y dile si se trata de un digito, una letra en minusculas o algun otro simbolo.
        Console.Write("Introduce un caracter: ");
        char l3 = Convert.ToChar(Console.ReadLine());
        if (l3 >= '0' && l3 <= '9')
        {
            Console.WriteLine("Es un digito");
        }
        else if (l3 == '.' || l3 == ',')
        {
            Console.WriteLine("Es un simbolo de puntuacion");
        }
        else
        {
            Console.WriteLine("No es un digito");
        }
    }
}



