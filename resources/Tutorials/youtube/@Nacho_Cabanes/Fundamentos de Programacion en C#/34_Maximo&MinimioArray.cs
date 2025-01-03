//! 034 - MAXIMO VALOR EN UN ARRAY

/* MAXIMO (Y MINIOM)
* Para el maximo (o el minimo): primer dato como valor provisional, y comparar con cada uno de los demas, cambiando si fuera necesario.
int maximo = dato[0];
for (i = i; i< cantidad; i++)
    if (dato[i] > maximo)
        maximo = dato[i]
*/

using System;

class ArrayMax
{
    static void Main()
    {
        /*
        int[] datos = { 5, 10, 15, 20, 25, 30, -2, 27, 17, 6 };

        int max = datos[0];
        int min = datos[0];
        for (int i = 0; i < datos.Length; i++)
        {
            if (datos[i] < min)
            {
                // max = datos[i];
                min = datos[i];
            }
            Console.WriteLine(min);
        }
        */

        //TODO: EJERCICIO PROPUESTO
        //* Pide al usuario 10 numeros reales de simplre precision y guardalos en un array y despues muestra el mayor de todos ellos.

        double[] datos = new double[10];
        double max = datos[0];
        
        for (int i = 0; i < datos.Length; i++)
        {
            Console.WriteLine($"Introduce un numero real {i + 1}: ");
            datos[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < datos.Length; i++)
        {
            if (datos[i] > max)
            {
                max = datos[i];
            }
        }
        Console.WriteLine(max);
    }
}