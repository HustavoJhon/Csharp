//! CONTACTO CON LA "CONSOLA"

/* ALGUNAS POSIBILIDADES:
* Situarse en otras coordenadas
* Escribir con colores
* Borrar la pantalla
* Leer teclas sin espera Intro
* Tamaño de la consola
*/

/* SITUARSE EN OTRAS COORDENADAS
* Console.SetCursorPosition(x,y);
- X empieza en margen izquierdo (desde 0)
- Y empieza en la linea superior (desde 0)
*/

/* ESCRIBIR CON COLORES
* Asignando valores distintos a 
    Console.BackgroundColor y Console.ForegroundColor

- Console.BackgroundColor = ConsoleColor.Red;
- Console.ForegroundColor = ConsoleColor.Blue;
*/

/* BORRAR LA PANTALLA
* Console.Clear();
? Se puede usar un color que no sea negro, si se cambian el "BackhoundColor"
*/

/* LEER TECLAS SIN ESPERA INTRO
* ConsoleKeyInfo tecla = Console.ReadKey();
* if (tecla.Key == ConsoleKey.RightArrow){...}

* Se puede "interceptar" la tecla pulsanda, para que no se muestre:
* ConsoleKeyInfo tecla = Console.ReadKey(true);
*/

/* LEER TECLAS SIN ESPERAR "INTRO" (Y 2)
* Console.ReadKey es "bloqueante", detiene el programa.
* Alternativa: consultar su valor solo si realmente hay una pulsacion que analizar:
if (console.KeyAvailabel)
{
    ConsoleKeyInfo tecla = Console.ReadKey();
}
*/

/* BONUS: TEMPORIZACION
* Thread.Sleep(milisegundos). Necesario un "using" adicional:
* using System.Theading;
* Thread.Sleep(50);
*/

/* TAMAÑO DE LA CONSOLA
* Tamanho de la ventana visible y tambien de "buffer" (que se podria ver haciendo "screen"):
* Console.SetBufferSize(80, 25)
* Console.SetWindowSize(80, 25)
*/

using System;
using System.Net;

class EjemploConsola
{
    static void Main()
    {
        /*
        int x = 30, y = 12;
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("Hola, Pulsa S..");
        ConsoleKeyInfo tecla;
        {
            tecla = Console.ReadKey( true );
        }
        while (tecla.KeyChar != 's');
        Console.ResetColor();
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Adios");
        */
        // TODO: EJERCICIO PROPUESTOS
        //? Haz una pelota (por ejemplo, usando una letra "O") que se mueva por la pantalla, rebotando cada vez que alcanza un borde de esta. Haz una pausa de unos 100 milisegundos entre un "FOTOGRAMA" de la animacion y el siguiente. Se repetira hasta que se pulse "Esc".
           // Dimensiones de la consola
        int anchoPantalla = Console.WindowWidth;
        int altoPantalla = Console.WindowHeight;

        // Posición inicial de la pelota
        int x = anchoPantalla / 2;
        int y = altoPantalla / 2;

        // Velocidad inicial de la pelota
        int dx = 1;  // Dirección en el eje X (1 = derecha, -1 = izquierda)
        int dy = 1;  // Dirección en el eje Y (1 = abajo, -1 = arriba)

        // Ocultar el cursor
        Console.CursorVisible = false;

        while (true)
        {
            // Verificar si se presionó la tecla Esc
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                break;

            // Dibujar la pelota en la nueva posición
            Console.Clear(); // Limpiar la pantalla
            Console.SetCursorPosition(x, y); // Establecer la posición del cursor
            Console.Write("O"); // Dibujar la pelota

            // Actualizar la posición de la pelota
            x += dx;
            y += dy;

            // Verificar colisiones con los bordes y cambiar dirección
            if (x <= 0 || x >= anchoPantalla - 1)
                dx = -dx; // Cambiar dirección en X
            if (y <= 0 || y >= altoPantalla - 1)
                dy = -dy; // Cambiar dirección en Y

            // Pausar 100 milisegundos entre fotogramas
            Thread.Sleep(100);
        }

        // Restaurar el cursor
        Console.CursorVisible = true;
    }
}