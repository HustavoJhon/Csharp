//! 043 - OPERACION POR SELECCION DIRECTA E INSERCION DIRECTA

/* SELECCION DIRECTA - ALGORITMO
* En cada pasada, se busca el menor de los datos y se intercambia

para i = 1 hasta n - 1
    posicMenor = i
    para j = i + 1 hasta n
        si A[j] < A[posicMenor]
            posicMenor = j
    Si posicMenor <> i
        intercambiar(A[i], A[posicMenor])
*/

/* SEL.DIRECTA: EJEMPLO (1)
* 30 20 40 60 15 Datos iniciales
30 15 Primera posada: se busca el menor de 1 a 5
15  30 es el 5to , se intercambia
15 20 40 60 30 Segunda pasada: menor de 2da a 5ta
15 20 40 60 30 es el 2da, no se intercambia
*/

/* SEL.DIRECTA: EJEMPLO (2)
15 20 40 60 30 Tercera pasada: menor de 3era a 5ta
15 20 30 60 40 Es el 5ta, se intercambia
15 20 30 60 40 Cuarta pasada: menor de 4ta a 5ta
15 20 30 40 60 Es la 5ta, no se intercambia

* 15 20 30 40 60 Datos ordenados
*/

/* SELECCION DIRECTA - C#

for (int i = 0; i < datos.Length - 1; i++)
{
    int posicMenor = i;
    for (int j = i + 1; j < datos.Length; j++)
    {
        if (datos[j] < datos[posicMenor])
        {
            posicMenor = j;
        }
    }
    if (posicMenor != i)
    {
        ? Intercambiar datos[i], datos[posicMenor]
    }
}
*/

/* INSERCION DIRECTA - ALGORITMO
* Compara cada elemeno con los del principio, que ya estan ordenados, y lo mueve a su posicion correcta.

para i = 2 hasta n
    j = i - 1
    mientras j >= 1 y A[j] > A[j + 1]
        intercambiar(A[j], A[j + 1])
        j = j - 1
*/

/* INS.DIRECTA: EJEMPLO - PASADA 1
* 30 20 40 60 15  Datos iniciales
30 20 Primera pasada: posicion 2 hacia atras
20 30 Dato 1 > dato 2, se intercambia
*/

/* INS.DIRECTA: EJEMPLO - PASADA 2
20 30 40 60 15 Resultado tras primera pasada
30 40 Segunda pasada: posicion 3 hacia atras
30 40 Dato 2 > dato 3, se intercambia
*/

/* INS.DIRECTA: EJEMPLO - PASADA 3
20 30 40 60 15 Resultado tras segunda pasada
40 60 Tercera pasada: posicion 4 hacia atras
20 30 40 15 Dato 3 > dato 4, no hay que hacer nada
*/

/* INS.DIRECTA: EJEMPLO - PASADA 4
20 30 40 60 15 Resultado tras tercera pasada
60 15 Cuarta pasada: posicion 4 hacia atras
15 60 Dato 4 > dato 5, se intercambia
15 40 Dato 3 > dato 4, se intercambia
15 30 Dato 2 > dato 3, se intercambia
15 20 Dato 1 > dato 2, se intercambia

* 15 20 30 40 60 Posicion 1, pasada terminada. Ordenado
*/


/* INSERCION DIRECTA - C#

for (i = 1; i < SIZE; i++)
{
    j = i - 1;
    while (j >= 0 && datos[j] > datos[j + 1])
    {
        oux = datos[j];
        datos[j] = datos[j + 1];
        datos[j + 1] = oux;
        j--;
    }
}
*/

/* 
? SON RAPIDAS ESTAS OPERACIONES?

* NO: sencillas pero lentas. El "doble for anidado" hace que su coste sea del orden de n^2 (casi 1.000.000 de comparaciones para 1.000 datos, un billon de comparaciones para un millo de datos).

* Hay alternativas mas rapidas, pero por lo general son mas complejas y suponen saber funciones y recursividad.

*Existe un ".Sort", que veremos en la proxima entrega.
*/


// TODO: EJERCICIOS PROPUESTOS
//? Crea un programa que pida al usuario 10 numeros enteros y los ordene usando Seleccion Directa. Muestra los datos resultantes tras la ordenacion. Opcionalmente, puedes mostrar el resultado tras cada pasada.

//* Repite el proceso usando Insercion Directa.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];

        // Solicitar 10 números al usuario
        Console.WriteLine("Ingresa 10 números enteros:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Mostrar opciones al usuario
        Console.WriteLine("Elige el método de ordenación:");
        Console.WriteLine("1 - Selección Directa");
        Console.WriteLine("2 - Inserción Directa");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                SeleccionDirecta(numbers);
                break;
            case 2:
                InsercionDirecta(numbers);
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

        // Mostrar el resultado final
        Console.WriteLine($"Resultado final: {string.Join(" ", numbers)}");
    }

    static void SeleccionDirecta(int[] numbers)
    {
        Console.WriteLine("Ordenando por Selección Directa...");
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int posMin = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[posMin])
                {
                    posMin = j;
                }
            }

            // Intercambiar si el menor no está en la posición i
            if (posMin != i)
            {
                int temp = numbers[i];
                numbers[i] = numbers[posMin];
                numbers[posMin] = temp;
            }

            // Mostrar el array después de cada pasada
            Console.WriteLine($"Pasada {i + 1}: {string.Join(" ", numbers)}");
        }
    }

    static void InsercionDirecta(int[] numbers)
    {
        Console.WriteLine("Ordenando por Inserción Directa...");
        for (int i = 1; i < numbers.Length; i++)
        {
            int j = i - 1;
            while (j >= 0 && numbers[j] > numbers[j + 1])
            {
                // Intercambiar
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
                j--;
            }

            // Mostrar el array después de cada pasada
            Console.WriteLine($"Pasada {i}: {string.Join(" ", numbers)}");
        }
    }
}
