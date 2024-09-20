//! 042 - ORDENACION "DE BURBUJA"

/* BURBUJA: ALGORITMO
* BubbleSort (burbuja)
? (Se intercambia cada pareja consecutiva que no esta ordenada)

Para i = 1 hasta n-1
    para j = 1 hasta n-i-1
        Si A[j] > A[j+1]
            Intercambiar(A[j], A[j+1])
*/

/* BURBUJA: EJEMPLO - PASADA 1
3 2 4 6 1 Datos iniciales
3 2 Se compara la posicion 1 con la 2
2 3 4 6 1 Estan al reves, se intercambia
3 4 Se compara la posicion 2 con la 3: OK
4 6 Se compara la posicion 3 con la 4: OK
6 1 Se compara la posicion 4 con la 5: Al reves
1 6 Se intercambia. Fin de la primera pasada
*/

/* BURBUJA: EJEMPLO - PASADA 2
* 2 3 4 1 6 Datos de la pasa 1 
3 2 Se compara la posicion 1 con la 2: OK
3 4 Se compara la posicion 2 con la 3: OK
4 1 Se compara la posicion 3 con la 4: Al reves
1 4 Se intercambia. Fin de la segunda pasada
*/

/* BURBUJA: EJEMPLO - PASADA 3
* 2 3 1 4 6 Datos de la pasada 2
2 3 Se compara la posicion 1 con la 2: OK
3 1 Se compara la posicion 2 con la 3: Al reves
1 3 Se intercambia. Fin de la tercera pasada
*/

/* BURBUJA: EJEMPLO - PASADA 4
* 2 1 3 4 6 Datos de la pasada 3
2 1 Se compara la posicion 1 con la 2: Al reves
1 2 3 4 6 Se Intercambia. Din de la cuarta pasada

Fin de la operacion
*/

/* BURBUJA - CRITICAS
* Lento: orden de n^2
    (para 1.000 datos, 1.000.000 de comparaciones;
    (para 1.000.000 datos, 1.000.000.000 de comparaciones)

* Coloca antes de los elementos "mas grandes" ("sinking sort")
* Alternativas: descendente / while
*/

/* BURBUJA: ALGORITMO ALTERNATIVO
Implematacion alternativa:
* Se compara cada elemento con todos los siguientes

Para i = 1 hasta n-1
    para j = i + 1 hasta n
        Si A[i] > A[j]
            Intercambiar(A[i], A[j])
*/

/* BURBUJA ALT.: EJEMPLO - PASADA 1
3 2 4 6 1 datos iniciales
3 2 Se compara la posicion 1 con la 2
2 3 Estan al reves, se intercambia
2 4 Se compara la posicion 1 con la 3: OK
2 6 Se compara la posicion 1 con la 4: OK
2 1 Se compara la posicion 1 con la 5: Al reves
1 3 4 6 2 Se intercambia. Fin la primera pasada 
*/

/* BURBUJA ALT.: EJEMPLO - PASADA 2
* 1 3 4 6 2 Datos tras la pasada 1
3 4 Se comapara la posicion 2 con la 3: OK
3 6 Se compara la posicion 2 con la 4: OK
3 2 Se compara la posicion 2 con la 5: Al reves
1 2 4 6 3 Se intercambia. Fin de la segunda pasada
*/

/* BURBUJA ALT.: EJEMPLO - PASADA 3
* 1 2 4 6 3 Datos de la pasada 2
2 4 Se compara la posicion 3 con la 4: OK
2 6 Se compara la posicion 3 con la 5: Al reves
1 2 3 6 4 Se intercambia. Fin de la tercera pasada
*/

/* BURBUJA ALT.: EJEMPLO - PASADA 4
* 1 2 3 6 4 Datos de la pasada 3
6 4 Se compara la posicion 4 con la 5: Al reves
1 2 3 4 6 Se intercambia. Fin de la cuarta pasada

Fin de la ordenacion
*/

/*  DE ALGORITMO A C# - 1
Algoritmo:

Para i = 1 hasta n-1
    para j = i + 1 hasta n
        Si A[i] > A[j]
            Intercambiar(A[i], A[j])
*/

/*  DE ALGORITMO A C# - 2

for (int i = 0; i < datos.Length - 1; i++)
    for (int j = i + 1; j < datos.Length; j++)
        if (datos[i] > datos[j])
            int aux = datos[i];
            datos[i] = datos[j];
            datos[j] = aux;
*/

/* VARIANTES (1)

* Existen variantes. Por ejemplo: algunos autores hacen bucles exterior decreciente

para i = n bajando hasta 2
    para j = 2 hasta i
        si a[j - 1] > a[j]
            intercambiar(a[j - 1], a[j]);
*/

/* VARIANTES (2)

* Tambien se puede planear un "do-while". para dejar de comprobar en cuando ya no haya cambios:

Repertir
    intercambiado = Falso
    Para i = 1 hasta n - 1
        Si a[i] > a[i + 1]
            intercambiar(a[i-1], a[i])
            intercambiado = Verdadero
Hasta que intercambiado = Falso
*/

// TODO: EJERCICIOS PROPUESTOS
//? Crea un programa que pida al usuario 10 numeros enteros y los ordene usando BubbleSort. Muestra los datos resultantes tras la odenacion. Opcionalmente, puedes mostrar el resultado tras cada pasada.

using System;

class BubbleSort
{
    static void Main()
    {
        int[] datos = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i}. Introduce un numero: ");
            datos[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (datos[i] > datos[j])
                {
                    int aux = datos[i];
                    datos[i] = datos[j];
                    datos[j] = aux;
                }
            }
        }
        for (int i = 0; i < 10; i++)
        {
            Console.Write(datos[i] + " ");
        }
    }
}