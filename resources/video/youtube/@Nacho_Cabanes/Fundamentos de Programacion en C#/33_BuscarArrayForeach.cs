//! 033 - BUSCAR EN UN ARRAY USANDO FOREACH 

/* BUSQUEDA EN ARRAYS (1: MAL)
for (i = 0; i < cantidad; i++) // Busqueda incorrecta
    if (datos[i] == 15)
        econtrado = true;
    else
        encontrado = false; //Error 
*/

/* BUSQUEDA EN ARRAYS (2: CONTADOR)
cantidad = 0;
for (i = 0; i < cantidad; i++) 
    if (datos[i] == 15)
        cantidad ++;
*/

/* RECUERDA: CUIDADO CON LOS REALES
! Peligroso!!
* comparar if (x == datos[i]) cuando se usan datos reales (puede haber errores de redondeo).
* Por lo general, habra que tener un cuenta un cierto "epsilon": if ((x >= datos[i] - 0.00if) && (x <= datos[i] + 0.00if))
*/

/* FOREACH
* foreach (tipo x in conjuto)...
* Solo para recorrer de principio a fin
* Solo para recorrer toda la longitud
* Solo si no necesitamos un contador
*/

/* DETENER LA BUSQUEDA
* Si solo queremos saber si esta o no, podemos detener la busqueda tras encontrar (prefereible "while" a "break":)
i= 0;
while (i < cantadad && !encontrado)
{
    if (datos[i] == 15)
        encontrado = true;
    i++;
}
*/
using System;
class ArraysBuscar
{
    static void Main()
    {
        int[] datos = {5, 10, 15, 20, 25};
        /* BUSQUEDA 1
        bool encontrado = false;
        for (int i = 0; i < datos.Length; i++)
        {
            if (datos[i] == 15)
            {
                encontrado = true;
            }
            else 
            {
                encontrado = false;
            }
        }
        Console.WriteLine(encontrado);
        */

        /* BUSQUEDA 2
        int cantidad = 0;
        for (int i=0; i < datos.Length; i++)
        {
            if (datos[i] == 15)
            {
                cantidad ++;
            }
        }
        Console.WriteLine(cantidad);
        if (cantidad > 0)
        {
            Console.WriteLine("Encontrado");
        }
        */

        /* FOREACH
        bool encontrado = false;
        foreach (int d in datos)
        {
            if (d == 15)
            {
                encontrado = true;
                break;
            }
            Console.WriteLine(encontrado);
        }    
        */

        /* WHILE
        bool encontrado = false;
        int i = 0;
        while (i < datos.Length && !encontrado)
        {
            if (datos[i] == 15)
            {
                encontrado = true;
            }
            i++;
            Console.WriteLine(encontrado);
        }
        */

        // TODO: EJERCICIO PROPUESTOS
        //? Pide al usuario 10 enteros largos. A continuacion, deberas pedirle un numero y decirle si estaba entre los 10 datos iniciales, luebo pedirle otro y asi sucesivamente, hasta que teclee la palabra "fin" en vez de un numero.

       // Crear un array de 10 enteros largos
        long[] numeros = new long[10];
        
        // Pedir 10 números al usuario
        Console.WriteLine("Introduce 10 números enteros largos:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt64(Console.ReadLine());
        }

        // Bucle para pedir números hasta que el usuario escriba "fin"
        while (true)
        {
            Console.Write("Introduce un número para comprobar (o escribe 'fin' para salir): ");
            string entrada = Console.ReadLine();

            // Verificar si el usuario ha escrito "fin"
            if (entrada.ToLower() == "fin")
            {
                break;
            }

            // Convertir la entrada a número y verificar si está en el array
            if (long.TryParse(entrada, out long numeroBuscado))
            {
                if (Array.Exists(numeros, n => n == numeroBuscado))
                {
                    Console.WriteLine("El número está en la lista.");
                }
                else
                {
                    Console.WriteLine("El número no está en la lista.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, introduce un número o 'fin' para salir.");
            }
        }

        Console.WriteLine("Programa finalizado."); 
    }
}