//! 019  - Contacto con las "excepciones"

//? Una "excepcion es un error grave que impide que el programa pueda continuar

using System;

class Division
{
    static void Main()
    {
        /*
        int a, b;
        try
        {
            Console.Write("Dime el dividendo: ");
            a = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Dime el divisor: ");
            b = Convert.ToInt32( Console.ReadLine() );

            Console.Write("Su dividion es: ");
            Console.WriteLine( a / b);
        }
        catch (FormatException)
        {
            Console.WriteLine("Algo ha ido mal");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir");
        }
        Console.WriteLine("final del programa... ");

        */

        int x, y;

        try
        {
            Console.Write("1. numero: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. numero: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("El resultado de la suma/resta es:");
            Console.WriteLine((x+y)/(x-y));
        }
        catch (FormatException)
        {
            Console.WriteLine("No se dividir en cero");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede divir");
        }
    }
}