//Calculadora Basica

Console.WriteLine("Ingresa el primer numero:"); 
double num1 = double.Parse(Console.ReadLine()??"");
Console.WriteLine("Ingresa el segundo numero:");    
double num2 = double.Parse(Console.ReadLine()??"");
//Instanciar el objeto

Calculadora calcu = new Calculadora(num1, num2);

//Seleccion de la operacion

Console.WriteLine("Selecciona la operación a realizar:");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar"); 
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");

int opcion = int.Parse(Console.ReadLine()??"");
switch (opcion)
{
    case 1:
                Console.WriteLine($"El resultado de la suma es: {calcu.Sumar()}");
        break;
    case 2:
        Console.WriteLine($"El resultado de la resta es: {calcu.Restar()}");
        break;
    case 3:
        Console.WriteLine($"El resultado de la multiplicación es: {calcu.Multiplicar()}");
        break;
    case 4:
        calcu.Dividir();
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}
