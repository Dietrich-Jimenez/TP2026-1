
Rectangulo rectangulo = new Rectangulo(9, 3);
double area = rectangulo.CalcularArea();
Console.WriteLine($"Area del rectangulo : {area}");

rectangulo.Perimetro();

Cuadrado cuadrado = new Cuadrado(9.5f);
Console.WriteLine($"El lado del cuadrado es: {cuadrado.Base}");
Console.WriteLine($"La altura del cuadrado es: {cuadrado.Altura}");
Console.WriteLine($"Area del cuadrado es: {cuadrado.CalcularArea()}");
Console.WriteLine($"Perímetro del cuadrado es: {cuadrado.Perimetro()}");






