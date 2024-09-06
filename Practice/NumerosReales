//! 023 - TIPOS DE DATOS REALES

/* NUMEROS REALES (1A)
* Coma fija:
* Cantidad de posiciones antes de la coma y despues de la coma prefijada
* Por ejemplo, con 4 + 3 cifras:
    ** El numero 23,45 se guardaria coomo 23, 450
    ** El numero 3,4562 se guardaria como 3,456
    ** El numero 12345,6 se guardaria de forma incorrecta, quiza como 2345,6
*/

/* NUMERO REALES (1B)
* Coma flotante:
* Importa la cantidad de "Cifras significativas" (antes y/o despues del ultimo 0):
    ** 23500: 3 cifras significativas (235 * 10^2)
    ** 0,0235: 3 cifras significativas (235 * 10^-4)
    ** 23005: 5 cifras significativas
*/

/* NUMEROS REALES (2B)
* Simple precision
    ** 32 Bits: -1,5.10^-45 a 3,4.10^38, 7 cifras significativas.

* Doble precision
    ** 64 Bits: 5,0.10^-324 a 1,7.10^308, 15-16 cifras significativas

* Con C#, se puede conseguir una precision aun mayor:
    ** 128 bits: 1.10-28 a 7,9.10^28, 28-29 cifras significativas
*/

/* TIPOS DE DATOS "REALES"
* Nombre  |  Precision
float    |   Simple (7 cifras)
double   |   Doble (15 cifras)
decimal  |   (Superio, en pocos lenguajes)
*/

/* CONVERTIR DE TEXTO A REAL
* Convert.ToSingle
* Convert.ToDouble
* Convert.ToDecimal
*/

/* 
!PROBLEMAS AL INTRODUCIR REALES
* Dame el primer numero
** 23,6
* Dame el segundo numero
** 34.2
* La suma 23,6 y 342 es 365,6
*/

using System;

class Circunferencia
{
    static void Main()
    {
        /* DOUBLE
        Console.Write("Dime el radio: ");
        double radio = Convert.ToDouble( Console.ReadLine());

        double pi = 3.14;

        double longitud = 2 * pi * radio;

        Console.WriteLine("La longitud es {0}", longitud);
        */

        /* FLOAT
        Console.Write("Dime el radio: ");
        float radio = Convert.ToSingle( Console.ReadLine());
        
        float pi = 3.141334f;
        float longitud = 2 * pi * radio;
        Console.WriteLine("La longitud es {0}", longitud);
        */

        //TODO: EJERCICIO PROPUESTO
        // Pide al usuario el radio de un circulo y muestra su superficie (pi por el radio al cuadrado)
        Console.Write("Ingresa el radio del circulo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        //valor aprox de PI
        double pi = 3.141592445;

        double superficie = pi * (radio * radio);

        Console.WriteLine("La suma del circulo es: {0}", superficie);
    }
}

