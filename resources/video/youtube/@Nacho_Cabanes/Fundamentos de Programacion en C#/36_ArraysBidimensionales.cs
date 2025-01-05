//! 036 - ARRAYS BIDIMENSIONALES

/* DIFERENCIA CON "CONVERNCIONALES"
* Array " convencional" o vector:
- |post. 0|post. 1|post. 2|post. 3|post. 4|

* Array bidimensional o matris
- |fila 1, col 0|pila 1, col 1|pila 1, col 2|pila 1, col 3|pila 1, col 4|
- |pila 2, col 0|pila 2, col 1|pila 2, col 2|pila 2, col 3|pila 2, col 4|
*/

/* ARRAYS MULTIDIMENSIONALES
* Para 2 grupos de 20 personas:
    - int datosDeAlumnos[40]; //Como unico grupo
    - int datosDeAlumnos[2,20]; //Habitual
    - int datosDeAlumnos[2][20]; //Estilo C
*/

/* ARRAYS RECTANGULARES (1)

- int[,] notas = new int[2,2];
- notas[0,0] = 1;
- notas[0,1] = 2;
-nota[1,0] = 3;
-nota[1,1] = 4;
*/

/* ARRYS RECTANGULARES (2)
* Para saber el tamano, no nos basta con ".Length", emplearemos ".GetLength", donde:

? n = 0 para la primera dimension (tipicamente las filas)
? n = 1 para la segunda dimension (columnas, en el caso de dos dimensiones)
*/

using System;

class ArrayBidim
{
    static void Main()
    {
        /*
        const int FILAS = 2, COLUMNAS = 5;
        float[,] datos = new float[2, COLUMNAS];

        for (int fila = 0; fila < datos.GetLength(0); fila++)
        {
            float sumaFila = 0;

            for (int columna = 0; columna < datos.GetLength(1); columna++)
            {
                Console.Write("Dime el dato {0}, {1}: ", fila+1, columna+1);
                datos[fila, columna] = Convert.ToSingle( Console.ReadLine() );
                sumaFila += datos[fila, columna];
            }

            Console.WriteLine($"La media de la fila es :{sumaFila / datos.GetLength(1)}");
        }

        float sumaTotal = 0;
        foreach (float f in datos)
        {
            sumaTotal += f;
        }
        Console.WriteLine($"La media global es: {sumaTotal / datos.Length}");
        */

        //TODO: EJERCICIO PROPUESTO
        //? Pide al usuario 2 bloques de 10 numeros reales de doble precision, guardalos en un array bidimensional y despues muestra el maximo de la primera fila, el maximo de la segunda fila y el maximo global.
        const int FILAS = 2, COLUMNAS = 10;
        double[,] datos = new double[FILAS, COLUMNAS];

        // Solicitar los números al usuario y almacenarlos en el array bidimensional
        for (int fila = 0; fila < FILAS; fila++)
        {
            for (int columna = 0; columna < COLUMNAS; columna++)
            {
                Console.Write($"Dime el número real {fila + 1}, {columna + 1}: ");
                datos[fila, columna] = Convert.ToDouble(Console.ReadLine());
            }
        }

        // Encontrar el máximo de la primera fila
        double maxFila1 = double.MinValue;
        for (int columna = 0; columna < COLUMNAS; columna++)
        {
            if (datos[0, columna] > maxFila1)
            {
                maxFila1 = datos[0, columna];
            }
        }

        // Encontrar el máximo de la segunda fila
        double maxFila2 = double.MinValue;
        for (int columna = 0; columna < COLUMNAS; columna++)
        {
            if (datos[1, columna] > maxFila2)
            {
                maxFila2 = datos[1, columna];
            }
        }

        // Encontrar el máximo global
        double maxGlobal = double.MinValue;
        foreach (double numero in datos)
        {
            if (numero > maxGlobal)
            {
                maxGlobal = numero;
            }
        }

        // Mostrar los resultados
        Console.WriteLine($"El máximo de la primera fila es: {maxFila1}");
        Console.WriteLine($"El máximo de la segunda fila es: {maxFila2}");
        Console.WriteLine($"El máximo global es: {maxGlobal}");

    }
}