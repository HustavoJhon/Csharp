//! 032 - CONTACTO CON LOS ARRAYS

/* ARRAYS (1 - IDEAS BASICAS)
* Conjunto de datos, todos del mismo tipo.
* Se le llama: tabla, vectore, matriz o array (arreglo?)
* Declaracion: tipo base seguido de []:
    int[] datos;
*/

/* ARRAYS (2 - RESERVA DE ESPACIO)
* Si no conocesmos el tamano al declarar:
    - int[] datos; //Primero: Declaracion
    - datos = new int[5]; //Despues, reserva de espacio
* Si conocemos el tamano cuando creamos el programa, en un paso:
    - int[] datos = new int[5]
*/

/* ARRAYS (3 - ASIGNAR VALORES)
* Asignacion de valores (se empieza a contar desde 0)
- datos[0] = 200
*/

/* ARRAYS (4 - ACCEDER A LOS DATOS)
* De forma "artesanal" (poco habitual):
    - suma = datos[0] + datos[1]...;
*/

/* ARRAYS (5 - ACCEDER, REPETITIVO)
* De forma repetitiva
    - sum = 0; //Valor inicial
    - for (i = 0; i <= 4; i++)
    -   sum += datos[i];
*/

/* ARRAYS (6 - DATOS INICIALES)
* Cuando se saben los datos iniciales, se pueden indicar entre llaves:
    - int[] edades = new int[5]{20, 19, 21, 22}

* O, abreviado (mas habitual):
    - int[] edades = {20, 19, 21, 22}
*/

/* CONSTANTES Y TAMANO
* Para recorrer todo el array, sera legible con constantes que con "numeros magicos":

- const in MAXIMO = 5;
- int[] numeros = new int[MAXIMO]
- for (int i = 0; i < MAXIMO; i++)
*/

/*  .LENGTH
* Alternativa para saber el tamano: .Length

- for (int i = 0; i < numeros.Length; i++)
    - suma += numeros[i];
*/

using System;

class Arrays01
{
    static void Main()
    {
        const int DIAS = 5;
        /* PRIMERA FORMA
        string[] dias;
        dias = new string[5];
        dias[0] = "Lunes";
        dias[1] = "Martes";
        dias[2] = "Miercoles";
        dias[3] = "Jueves";
        dias[4] = "Viernes";
        */

        /* SEGUNDA FORMA 
        string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
        Console.WriteLine(dias[0]);
        */
        
        /* RECORRER
        ? for (int i = 0; i < dias.Length; i++)
        for (int i = 0; i < DIAS; i++)
        {
            Console.WriteLine(dias[i]);
        }
        * orden inverso
        Console.Write("Orden inverso: ");
        ? for (int i = DIAS - 1; i >= 0; i--)
        for (int i = dias.Length - 1; i >= 0; i--)
        {
            Console.Write(dias[i] + " ");
        }
        */
        //TODO: EJERCICIO
        //? Crea un programa que pida al usuairo 4 numeros enteros, los memorice (utilizando un array), calcule su media artimética y la muestre por pantalla la media y los datos tecleados.
        Console.WriteLine("Ejercicio 1");
        Console.WriteLine("Ingresa 4 numeros");
        int[] n4 = new int[4];
        for (int i = 0; i < n4.Length; i++)
        {
            n4[i] = Convert.ToInt32(Console.ReadLine());
        }
        int media = n4[0] + n4[1] + n4[2] + n4[3];
        Console.WriteLine("La media es: " + media / 4);

        Console.WriteLine("Ejercicio 2");
        //? Un programa que almacene en una tabla el numero de dias que tiene cada mes (supondremos que es una ano no bisiesto), pida al usuario que le indique un mes (1=enero, 12=diciembre) y muestre por pantalla el numero de dias que tiene ese mes.
        // Arrays que almacenan de dias mes en un ano no bisiesto
        int[] diasPorMes = {31,28,31,30,31,30,31,31,30,31,30,31};

        // Pedir al usuario que ingrese un numero de mes
        Console.Write("Introduce el numero del mes (1=enero, 12=diciembre): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        // Verficar si el mes este en el rango validado
        if (mes >= 1 && mes <= 12)
        {
            // Mostrar el numero de dias del mes
            Console.WriteLine("El mes {0} tiene {1} dias", mes, diasPorMes[mes - 1]);
        }
        else
        {
            //Mostrar mensaje de error si el mes no es valido
            Console.WriteLine("El numero de mes no es valido.");
        }


        //? A partir del ejercicio anterior, crea otro que pida al usuario que le indique la fecha, formada por dia (1 al 31) y el mes (1=enero, 12=diciembre) y como respuesta muestre en pantalla el numero de dias que quedan hasta final de ano
        Console.WriteLine("Ejercicio 3");
        // Pedir al usuario que ingrese el dia
        Console.Write("Introduce un dia del mes");
        int dia = Convert.ToInt32(Console.ReadLine());

        //Restar los dias restantes del mes actual
        int diasRestantes = 0;
        diasRestantes += diasPorMes[mes - 1] - dia;
        // Sumar los dias de los meses restantes
        for (int i = mes; i < 12; i++)
        {
            diasRestantes += diasPorMes[i];
        }
        Console.WriteLine($"Faltan {diasRestantes} dias hasta el final del ano");
        

    }
}
