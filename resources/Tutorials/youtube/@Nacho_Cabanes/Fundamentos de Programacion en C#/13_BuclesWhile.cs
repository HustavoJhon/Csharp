//! 013 - BUCLES CON "WHILE"

using System;

class Bucles()
{
    static void Main()
    {
        int a, b;

        Console.Write("Dime el dividendo: ");
        a = Convert.ToInt32( Console.ReadLine());
        Console.Write("Dime el divisor: ");
        b = Convert.ToInt32( Console.ReadLine());


        /*
        if (b != 0)
        {
            Console.Write("Su dividendo es: ");
            Console.WriteLine( a / b );
        }
        else
        {
            Console.WriteLine("No puedo dividir");

            Console.WriteLine("Dime el divisor: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Su division es: ");
            Console.WriteLine( a / b ); 
        }
        Console.WriteLine("Hasta luego");
        */

        while (b == 0)
        {
            Console.WriteLine("No puedo dividir");

            Console.Write("Dime el divisor : ");
            b = Convert.ToInt32( Console.ReadLine());
        }

        Console.Write("Su division es: ");
        Console.WriteLine( a / b );

        /*
        TODO: EJERCICIO PROPUESTO
        * Pide al usuario una contraseña numerica. Debe repetirse hasta que introduzca "1234", momento en el que le responderas "Bienvenido"
        */

        Console.WriteLine("--EJERCICIO--");

        int password;

        Console.Write("Intro you password: ");
        password = Convert.ToInt32( Console.ReadLine() );

        while ( password != 1234)
        {
            Console.WriteLine("You password is incorrect!!!");

            Console.Write("Intro you password again: ");
            password = Convert.ToInt32( Console.ReadLine() );
        }
        Console.WriteLine("Welcome!!!");
    }
}