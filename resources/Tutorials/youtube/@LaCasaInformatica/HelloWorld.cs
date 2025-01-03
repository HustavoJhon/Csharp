//! HOLA MUDNO EN C# - CLASE #2

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hello World");
        Console.Write("Sin salto de linea"); //Sin salto de linea
        Console.WriteLine(""); //Salto de linea

        //"\n" = salto de linea
        Console.WriteLine("Salto de \nLinea");

        //"\b" = retroceder
        Console.WriteLine("Retroceder \bLinea");    

        //"\t" = tabulador
        Console.WriteLine("Tabulador de \tLinea");

        //"\v" = tabulador vertical
        Console.WriteLine("Tabulador vertical \vLinea");

        //"\f" = salto de pagina
        Console.WriteLine("Salto de pagina \fLinea");

        //"\r" = retorno de carro
        Console.WriteLine("Retorno de \rLinea");

        //"\0" = caracter nulo
        Console.WriteLine("Caracter nulo \0Linea");

        //"\a" = alerta (pitido)
        Console.WriteLine("Alerta \aLinea");

        //? Concadenacion
        Console.WriteLine("\nConcadenacion" + " con +");
        Console.WriteLine($"Concadenacion con $");
        Console.WriteLine("Concadenacion con {} llaves");
    }
}