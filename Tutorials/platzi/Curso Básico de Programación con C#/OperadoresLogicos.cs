bool valor1 = true;
bool valor2 = false;
bool valor3 = true;

bool resultAnd = valor1 && valor2 && valor3;
bool resultOr = valor || valor2 || valor3;
bool resultOrAnd = (valor && valor2) || valor3;

Console.WriteLine(resultAnd);
Console.WriteLine(resultOr);
Console.WriteLine(resultOrAnd);
