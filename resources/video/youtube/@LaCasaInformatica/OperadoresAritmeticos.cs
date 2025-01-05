//! OPERADORES ARITMETICOS - CLASE #4

//TODO: Operadores aritmeticos
//* Suma             |  Signo =  + 
//* Resta            |  Signo = - 
//* Multiplicacion   |  Signo = * 
//* Division         |  Signo = / 
//* Residuo          |  Signo = % 
//* Potencia         |  Signo = ^ 
//* Division Entera  |  Signo = / 

//* Incremento | Signo = ++
//* Decremento | Signo = --



int suma = 5 + 3; //8
int resta = 5 - 3; //2
int multiplicacion = 5 * 3; //15
int division = 10 / 2; //2
int residuo = 10 % 2; //0
int potencia = 2 ^ 3; //8
int divisionEntera = 10 / 3; //3

int incremento = 5; //5
incremento++;
int decremento = 5; //5
decremento--;


Console.WriteLine("La suma es: " + suma);
Console.WriteLine("La resta es: " + resta);
Console.WriteLine("La multiplicacion es: " + multiplicacion);
Console.WriteLine("La division es: " + division);
Console.WriteLine("El residuo es: " + residuo);
Console.WriteLine("La potencia es: " + potencia);
Console.WriteLine("La division entera es: " + divisionEntera);
Console.WriteLine("El incremento es: " + incremento);
Console.WriteLine("El decremento es: " + decremento);

// =====================================================================

//! OPERADORES DE INCREMENTO Y DECREMENTO - CALSE #5

//? INCREMENTO
int a = 0;
a++;
a+=5;
Console.WriteLine(a);

//? DECREMENTO 
int b = 0;
b--;
b-=5;
Console.WriteLine(b);
