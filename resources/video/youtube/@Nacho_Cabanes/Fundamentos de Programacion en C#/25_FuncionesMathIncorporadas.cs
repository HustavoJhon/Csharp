//! 024 - FUNCIONES MATEMATICAS INCORPORADAS

//* Parte del lenguaje

//* En C#, se debe preceder de "Math.", como en "Math.Sqrt(16)"

//* En la mayoria de los casos, reciben uno o dos "datos" que seran "double" y devuelven un resultado que tambien sera "double"

//? Raiz cuadrada: x = Math.Sqrt(4);
//? Potencia: y = Math.Pow(2,3);
//? Valor abosoluto: n = Math.Abs(x);
//? Trigonometricas: Sin(x): Seno; Cos(x): Coseno; Tan(x): Tangente; Acos(x): Asin(x): Arco seno; Sinh(x): Seno hiperbolico...
//? Redondeo: Round(x, cifras): Redondea un numero; Ceiling(x): El valor entero superior a x  mas cercano a el; Floor(x): El mayor valor que es menor que x
//? Logaritmos  y exponenciales: Exp(x): Exponencial de x (e elevado a x): Log(x): logaritmo natural (o neperiano, en base "e"); Log10(x):Logaritmo en base 10

/* USO DE TRIGONOMETRICAS
* Los anngulos se deben indicar en radianes, no en grados:

* double anguloGrado = 45;

* dobule anguloRadianes = anguloGrados * Math.PI /180.0;

* Console.WriteLine("El coseno de 45 grados es: {0}", Math.Cos(anguloRadiantes));
*/

using System;

class Circunferencia
{
    static void Main()
    {
        /*
        Console.Write("Dime un angulo en grados: ");
        double anguloGrados = Convert.ToDouble(Console.ReadLine());
        double anguloRadianes = anguloGrados * Math.PI /180.0;
        Console.WriteLine("El seno de {0} grados es : {1}", anguloGrados, Math.Sin(anguloRadianes));

        Console.Write("Que raiz quieres hallar? ");
        Console.WriteLine(Math.Sqrt(Convert.ToDouble(Console.ReadLine())));
        */
        //TODO: EJERCICIOS PROPUESTOS
        //? Pide al usuario los dos catetos de un triangulo rectangulo y muestra el valor de su hipotenusa, usando el teorema de pitagotas.
        Console.WriteLine("Calcule la hipotenusa de un triangulo rectangulo");
        Console.Write("Primer cateto: ");
        double cateto1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Segundo cateto: ");
        double cateto2 = Convert.ToDouble(Console.ReadLine());

        double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
        Console.WriteLine("La hipotenusa es {0}", hipotenusa);

        //? Pide un numero al usuario y calcula su raiz cubica, elevado a 1/3
        Console.WriteLine("Calcula la raiz cubica de un numero");
        Console.Write("Ingrese un numero: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        double raizCubica = Math.Pow(n1,1.0/3.0);
        Console.WriteLine("La raiz cubica de {0} es: {1}",n1, raizCubica);

        //? Si has estudiado trigonometria: Pide al usuario un angulo, en grados, y muestra el valor de su seno, su coseno y su tangente.
        Console.WriteLine("Calcula es seno, coseno y tangente de un agulo");
        Console.WriteLine("Ingrese un angulo en grados: ");
        double anguloGrados = Convert.ToDouble(Console.ReadLine());
        double angulosRadianes = anguloGrados * (Math.PI / 180.0);

        double seno = Math.Sin(angulosRadianes);
        double coseno = Math.Cos(angulosRadianes);
        double tangente = Math.Tan(angulosRadianes);

        Console.WriteLine($"Seno: {seno}");
        Console.WriteLine($"Coseno: {coseno}");
    }
}

