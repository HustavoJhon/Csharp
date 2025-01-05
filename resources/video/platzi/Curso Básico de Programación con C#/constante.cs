var radio = 0d; //d -> decimales
var resultado = 1.1;

const double Pi = 3.14

const double SiempreSeEscribeAsi = 0d;

Console.WriteLine("Bienvenido, calculemos circulos!");
// PI * radio*radio 
Console.WriteLine("Ingrese el valor del radio");
double radio = Convert.ToDouble(Console.ReadLine());
radio = Convert.ToDouble(Console.ReadLine());

resultado = Math.PI * radio * radio;
//resultado = Math.Pi * radio * radio;

Console.WriteLine("El area de tu ciculo es de: " + resultado);
