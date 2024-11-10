//! 014 - BUCLES CON "DO-WHILE"

using System;


class Dowhile
{
    static void Main()
    {
        int a, b;

        Console.Write("Dime el dividendo: ");
        a = Convert.ToInt32( Console.ReadLine() );

        do 
        {
            Console.Write("Dime el dividendo: ");
            b = Convert.ToInt32( Console.ReadLine() );

            if (b ==0)
            {
                Console.WriteLine("No puedo dividir");
            }
        }
        while (b == 0);

        Console.Write("Su division es: ");
        Console.WriteLine( a / b);

        /* 
        TODO: EJERCICIO PROPUESTO
        * Crea una nueva version del ejercicio anterior, que pedia una contraseña numerica hasta que se introdujese "1234".
        * Esta vez deberas usar "Do-While" en vez de "while". 
        */

        Console.WriteLine("--EJERCICIO--");

        int password = 1234;
        int user;

        // Console.Write("Intro your Password: ");
        // password = Convert.ToInt32( Console.ReadLine() );

        do
        {
            Console.Write("Intro your Password: ");
            user = Convert.ToInt32( Console.ReadLine() );
            if (password != user)
            {
                Console.WriteLine("Your password is fail!!!");
                Console.WriteLine("Again now type your password");
            }
            else
            {
                Console.WriteLine("Welcome!!!");
                break;
            }
        }
        while (password == 1234);
    }
}
