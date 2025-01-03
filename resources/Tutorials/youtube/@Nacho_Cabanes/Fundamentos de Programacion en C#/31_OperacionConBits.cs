//! 031 - OPERACIÓNS CON BITS

/*  OPERACIÓNS CON BITS
* Complemento (not): ~1100 = 0011
* Producto logico (and): 1101 & 1011 = 1001
* Suma logica: 1101 | 1011 = 1111
* Suma explicita (xor): 1101 ^ 1011 = 0110
* Despl. Izqda: 1101 << 2 = 11010
* Despl. Derecha: 1101 >> 2 = 0011
*/

using System;

class NumerosBinarios
{
    static void Main()
    {
        /*
        int n2 = Convert.ToInt32("01001101", 2);
        int n3 = 0b10111111;
        Console.WriteLine( n2 | n3);
        Console.WriteLine(Convert.ToString(n2, 2));
        Console.WriteLine(Convert.ToString(n3, 2));

        Console.WriteLine(Convert.ToString(n2 | n3, 2) + " OR");
        Console.WriteLine(Convert.ToString(n2 & n3, 2) + " AND");
        Console.WriteLine(Convert.ToString(n2 ^ n3, 2) + " XOR");

        Console.WriteLine(Convert.ToString(~ n3, 2) + " NOT");
        Console.WriteLine();
        Console.WriteLine(n3);
        Console.WriteLine(Convert.ToString(n3 << 2, 2) + " Despl. Izqda");
        Console.WriteLine(n3 >> 2);
        Console.WriteLine(Convert.ToString(n3 >> 2, 2) + " Despl. Derecha");
        Console.WriteLine(n3 << 2);
        */
        string frase = "Hola";

        foreach (char letra in frase)
        {
            char letra1 = (char) (letra ^ 1);
            Console.WriteLine(letra1);
            char letra2 = (char) (letra ^ 1);
            Console.WriteLine(letra2);
        }
        //TODO: EJERCICIO PROPUESTO
        //? Crea un programa que pida al usuario una cadena de texto, y cree un nueva cadena encriptada usando una operacion "xor 2". Luego debera mostrar y generar una tercera cadena, volviendo a aplicar la operacion "xor 2" y mostrarla (debera coincidir con el texto inicial)
        // Pedir al usuario una cadena de texto
        Console.Write("Introduce una cadena de texto: ");
        string textoOriginal = Console.ReadLine();

        // Encriptar el texto aplicando XOR con 2
        string textoEncriptado = EncriptarDesencriptar(textoOriginal, 2);
        Console.WriteLine("Texto encriptado: " + textoEncriptado);

        // Desencriptar el texto aplicando XOR nuevamente con 2
        string textoDesencriptado = EncriptarDesencriptar(textoEncriptado, 2);
        Console.WriteLine("Texto desencriptado: " + textoDesencriptado);

        // Comprobar si coincide con el texto original
        if (textoOriginal == textoDesencriptado)
        {
            Console.WriteLine("El texto desencriptado coincide con el texto original.");
        }
        else
        {
            Console.WriteLine("El texto desencriptado NO coincide con el texto original.");
        }
        }

        static string EncriptarDesencriptar(string texto, int clave)
        {
            char[] resultado = new char[texto.Length];
            for (int i = 0; i < texto.Length; i++)
            {
                // Aplicar XOR a cada caracter
                resultado[i] = (char)(texto[i] ^ clave);
            }
            return new string(resultado);
        }
    }
