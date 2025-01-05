//! 037 - ARRAYS DE ARRAYS

/*  ARRAYS DE ARRAYS (1)
int[][] notas; //Declaracion

* cuando sabemos el tamano
int[][] notas = new int[3][]; //Arrays de 3 arrays
notas[0] = new int[10]; //Asignando valores
notas[1] = new int[15];
notas[2] = new int[12];
*/

/* ARRAYS DE ARRAYS (2)
* Para saber el tamano del array "global": ".Length"
* Para saber el tamano de cada subarray: Tambien ".Length"

? Ejemplo:
for (int i = 0; i < notas.Length; i++)
    for (int j = 0; j < notas[i].Length; j++)
    ...
*/

using System;

class ArrayBi
{
    static void Main()
    {
        /*
        const int FILA = 2;
        float[][] datos = new float [FILA][];

        for (int fila = 0; fila < FILA; fila++)
        {
            Console.WriteLine("Dime el tamano de esta fila");
            int columnas = Convert.ToInt32( Console.ReadLine());
            datos[fila] = new float [columnas];

            for (int columna = 0; columna < columnas; columna++)
            {
                Console.WriteLine("Dime el dato {0} {1}", fila+1, columna+1);
                datos[fila][columna] = Convert.ToSingle( Console.ReadLine() );
            }
        }

        for (int fila = 0; fila < datos.Length; fila++)
        {
            float sumaFila = 0;
            for (int columna = 0; columna < datos[fila].Length; columna++)
            {
                sumaFila += datos[fila][columna];
            }
            Console.WriteLine("La media de la fila es " + sumaFila / datos[fila].Length);
        }

        float sumaTotal = 0;
        int cantidad = 0;
        foreach (float[] fila in datos)
        {
            foreach (float f in fila)
            {
                sumaTotal += f;
                cantidad++;
            }
        }
        Console.WriteLine("La media global es: " + sumaTotal / cantidad);
        */

        //TODO: EJERCICIO PROPUESTO
        //? Pide al usuario el tamano de dos bloques de datos (enteros cortos) para crear una array de arrays. Pidele tambien los datos individuales que desea guarda. Finalmente, calcula y muestrea el maximo del primer sub-array, el del segundo y el global.
        const int BLOQUES = 2;
        short[][] datos = new short[BLOQUES][];

        // Solicitar el tamaño de los bloques y los datos individuales
        for (int bloque = 0; bloque < BLOQUES; bloque++)
        {
            Console.WriteLine($"Dime el tamaño del bloque {bloque + 1}:");
            int columnas = Convert.ToInt32(Console.ReadLine());
            datos[bloque] = new short[columnas];

            for (int columna = 0; columna < columnas; columna++)
            {
                Console.WriteLine($"Dime el dato {bloque + 1}, {columna + 1}:");
                datos[bloque][columna] = Convert.ToInt16(Console.ReadLine());
            }
        }

        // Encontrar el máximo del primer bloque
        short maxBloque1 = short.MinValue;
        for (int columna = 0; columna < datos[0].Length; columna++)
        {
            if (datos[0][columna] > maxBloque1)
            {
                maxBloque1 = datos[0][columna];
            }
        }

        // Encontrar el máximo del segundo bloque
        short maxBloque2 = short.MinValue;
        for (int columna = 0; columna < datos[1].Length; columna++)
        {
            if (datos[1][columna] > maxBloque2)
            {
                maxBloque2 = datos[1][columna];
            }
        }

        // Encontrar el máximo global
        short maxGlobal = short.MinValue;
        foreach (short[] bloque in datos)
        {
            foreach (short numero in bloque)
            {
                if (numero > maxGlobal)
                {
                    maxGlobal = numero;
                }
            }
        }

        // Mostrar los resultados
        Console.WriteLine($"El máximo del primer bloque es: {maxBloque1}");
        Console.WriteLine($"El máximo del segundo bloque es: {maxBloque2}");
        Console.WriteLine($"El máximo global es: {maxGlobal}");
    }
}

