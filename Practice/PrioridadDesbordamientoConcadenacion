// 008 - PRIORIDAD, DESBORDAMIENTO {0} {1}
using System;

class Prioridad
{
    static void Main()
    {
        int a, b;
        
        Console.Write("Ingrese un numero: ");
        a = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Ingrese un segundo numero: ");
        b = Convert.ToInt32( Console.ReadLine() );
        
        // Concadenacion de datos con {} por indice
        Console.WriteLine("La suma de {0} y {1} es: {2}", a, b, a+b);
        
        // PRIORIDAD
        Console.WriteLine(2+3*5); //multiplicaciones > divisiones > suma > resta
        
        // Desbordamiento
        int x = 1000000;
        int y = 5000000;
        int z = x * y;
        Console.WriteLine(z); // la informacion que se guarda no es infinita por ello es mejor no exedernos con algunos tipos de datos
        
        // EJERCICIO PROPUESTO
        // MUESTRA LA TABLA DE MULTIPLICAR DEL NUMERO QUE SE ESCOJA EL USUARIO. POR EJEMPLO, SI EL USIARIO ELIGE EL 5, ESCRIBIRAS DESDE 5 X 0 = 0 HASTA 5 X 10 = 50. COMO NO SABEMOS MANEJAR "BUCLES" (ESTRUCTURA REPETITIVAS), SERA UN PROGRAMA MUY REDUNDANTE.
        
        int numero;
        
        Console.Write("Escoje un numero para multiplicar: ");
        numero = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine("LA TABLA DE MULTIPLICAR DE {0} es:", numero);
        Console.WriteLine("{0} X {1} = {2}", numero, 0, numero*0);
        Console.WriteLine("{0} X {1} = {2}", numero, 1, numero*1);
        Console.WriteLine("{0} X {1} = {2}", numero, 2, numero*2);
        Console.WriteLine("{0} X {1} = {2}", numero, 3, numero*3);
        Console.WriteLine("{0} X {1} = {2}", numero, 4, numero*4);
        Console.WriteLine("{0} X {1} = {2}", numero, 5, numero*5);
        Console.WriteLine("{0} X {1} = {2}", numero, 6, numero*6);
        Console.WriteLine("{0} X {1} = {2}", numero, 7, numero*7);
        Console.WriteLine("{0} X {1} = {2}", numero, 8, numero*8);
        Console.WriteLine("{0} X {1} = {2}", numero, 9, numero*9);
        Console.WriteLine("{0} X {1} = {2}", numero, 10, numero*10);
    }
}