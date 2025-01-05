//! 028 - DATOS "BOOLEANOS"

/* BOOLEANOS (1)
* En honor a George Boole
* Valor: true o false
* Declaracion: bool encontrado;
* Valor prefijado: encontrado = true;
*/

/* BOOLEANOS (2)
* Valor a partir de una condicion

if (numero == oculto)
encontrado = true;
else
eocnotrado = false;

* mas compacto
econtrado = (numero == oculto);
*/

/* BOOLEANOS (3)
* Para usar su valor
if (encontrado == true)
Console.WriteLine("Encontrado");
* O, preferible, mas compacto
if (encontrado)
Console.WriteLine("Encontrado");
*/

using System;

class AdivinarUnNumero
{
    static void Main()
    {
        /*
        int oculto, n;
        int maxIntentos = 9, intentoActual = 0;
        bool acertado, quedaIntentos;

        oculto = DateTime.Now.Millisecond;

        do
        {
            Console.Write("Dime un numero del 0 al 999: ");
            n = Convert.ToInt32(Console.ReadLine());

            acertado = n == oculto;

            if (n == oculto)
                Console.WriteLine("Enhorabuena");
            else if (n < oculto)
                Console.WriteLine("Demasiado bajo");
            else
                Console.WriteLine("Demasiado alto");
            
            intentoActual++;

            quedaIntentos = intentoActual < maxIntentos;
            
            Console.WriteLine("Intento restante: " + (maxIntentos - intentoActual));

        } while (! acertado && quedaIntentos);

        if (! acertado)
            Console.WriteLine("Has perdido el numero era: " + oculto);

        Console.WriteLine("Gracias por jugar");
        Console.WriteLine("\nPresione una tecla para terminar");
        */

        //TODO: EJERCICIOS PROPUESTOS
        //? Imaginemos que estamos haciendo parte de la logica de un juego. Pregunta al usuario las vidas restantes y crea una variable "booleana" llamada "quedanVidas", que sera verdad si las vidas son mas de cero. Pregunta el nivel actual. La variable "juegoCompletado" sera cierta si el nuevel es el 11. La variable "partidaTerminada" sera verdad si no quedan vidas o si se ha completado el juego.
        Console.WriteLine("\nEjercicio propuesto");
        Console.WriteLine("Cuantas vidas tiene el usuario?");

        // Preguntar al usuario cuántas vidas quedan
        Console.Write("Ingresa las vidas restantes: ");
        int vidasRestantes = Convert.ToInt32(Console.ReadLine());

        // Crear la variable booleana "quedanVidas"
        bool quedanVidas = vidasRestantes > 0;
        Console.WriteLine($"¿Quedan vidas? {quedanVidas}");

        // Preguntar al usuario el nivel actual
        Console.Write("Ingresa el nivel actual: ");
        int nivelActual = Convert.ToInt32(Console.ReadLine());

        // Crear la variable booleana "juegoCompletado"
        bool juegoCompletado = nivelActual == 11;
        Console.WriteLine($"¿Juego completado? {juegoCompletado}");

        // Crear la variable booleana "partidaTerminada"
        bool partidaTerminada = !quedanVidas || juegoCompletado;
        Console.WriteLine($"¿Partida terminada? {partidaTerminada}");


    }
}
