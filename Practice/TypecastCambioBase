//! 024 - FORMATO DE NUMEROS, TYPCAST, CAMBIOS DE BASE

/* FORMATEO DE NUMEROS (1)
* suma.ToString("0.00")
* Formato basicos:
    0 = la cifra se mostrara (0 si no la hay).
    # = la cifra solo se mostrara si existe.
    . = posicion para el punto decimal.
* Se pueden usar otras abreviaturas: N5 = "cinco cifras decimales"
*/

/* FORMATEO DE NUMEROS (2)
* double n = 12.34;
* Console.WriteLIne(n.ToString("N1")); -> 12.3
* Console.WriteLIne(n.ToString("N3")); -> 12.340
* Console.WriteLIne(n.ToString("0.0")); -> 12.3
* Console.WriteLIne(n.ToString("0.000")); -> 12.340
* Console.WriteLIne(n.ToString("#.#")); -> 12.3
* Console.WriteLIne(n.ToString("#.###")); -> 12.34
*/


/* FORZADO DE TIPOS (TYPE CAST)
* Para forzar qeu cierto dato sea interpretado como de otro tipo de datos:
* float pi = (float) 3.14152654
* (como alternativa a 3.141592654f)
* int piSinDecimales = (int) pi;
* (Solo se puede usear cuando la conversion es "trivial": double a float, int a byte... pero no a/desde cadena de texto, por ejemplo)
*/

/* CAMBIO DE BASE (1)

* Hexadecimal:
    - Convet.ToString(n, 16)
* Binario:
    - Convert.ToString(n 2)

* Forma compacta para hexadecimal
    - numero.ToString("X")

* De hexadecimal a decimal:
    - int n1 = Convert.ToInt32("1a", 16);
    - O si es un valor prefijado: int n1 = 0x1 a;

* De binario a decimal:
    - int n2 = Convert.ToInt32("11001001",2);

*/


using System;

class Circunferencia
{
    static void Main()
    {
        double n = 912.34765445;
        Console.WriteLine(n);
        Console.WriteLine(Convert.ToSingle(n));
        Console.WriteLine((float)n);
        Console.WriteLine(Convert.ToInt32(n));
        Console.WriteLine((int)n);

        //TODO: EJERCICIOS PROPUESTOS
        //? Pide al usuario el radio de un circulo y muestra su superficie (PI multiplicado por el radio al cuadrado), usando con dos decimales.
        //? Pide al usuario numeros y muestra su equivalente en el sistema binario y en el sistema hexadecimal. El programa se repetira hasta que el numero introducido sea 0.
    }
}

