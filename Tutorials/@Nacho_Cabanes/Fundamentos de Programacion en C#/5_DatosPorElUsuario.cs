// 005 - DATOS INTRODUCIDOS POR EL USUARIO 

// Variables
// Espacio en el que guardar informacion
// Se les asocia un nombre
// Se les asocia un "Tipo de Datos"

int a,b;

Console.Write("Dime el primer numero: ");
a = Convert.ToInt32( Console.ReadLine() );

Console.Write("Dime el segundo numero: ");
b = Convert.ToInt32( Console.ReadLine() );

Console.Write("Su suma es: ");
Console.WriteLine(a+b);


// EJERCICIOS PROPUESTO
// PIDE AL USUARIO DOS NUMEROS ENTEROS. CALCULA (Y MUESTRA) CUANTO ES SU DIVISION ENTERA Y EL RESTO DE ESA DIVISION

int x, y;
Console.Write("Ingrese el primer numero: ");
x = Convert.ToInt32( Console.ReadLine());


Console.Write("Ingrese el segundo numero: ");
y = Convert.ToInt32( Console.ReadLine() );

Console.Write("La division entera es: ");
Console.WriteLine(x/y);

Console.Write("Y el resto de la division es: ");
Console.WriteLine(x%y);
