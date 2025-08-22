//Calculadora Basica

Console.WriteLine("Ingresa el primer numero:"); 
double num1 = double.Parse(Console.ReadLine()??"");
Console.WriteLine("Ingresa el segundo numero:");    
double num2 = double.Parse(Console.ReadLine()??"");

Calculadora calcu1 = new Calculadora(num1, num2);
Calculadora calcu2= new Calculadora(1, 2);
Calculadora sumaCalcu = calcu1 + calcu2; // Uso del operador sobrecargado

Console.WriteLine($"El resultado de la suma de calculadoras es: {sumaCalcu.numero1}.{sumaCalcu.numero2}");

/*
//Seleccionar el tipo de calculadora
Console.WriteLine("Selecciona el tipo de calculadora:");
Console.WriteLine("1. Calculadora Básica");
Console.WriteLine("2. Calculadora Científica");
int tipoCalculadora = int.Parse(Console.ReadLine()??"");

switch(tipoCalculadora)
{
    case 1:
    //Instanciar el objeto
      Calculadora calcuB = new Calculadora(num1, num2);
        Console.Write("Has seleccionado la Calculadora Básica.");
        Console.WriteLine("Selecciona la operación a realizar:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine($"¨Primer numero {calcuB.numero1}");
        Console.WriteLine($"¨Segundo numero {calcuB.numero2}");


        int opcion = int.Parse(Console.ReadLine() ?? "");
        switch (opcion)
        {
            case 1:
                Console.WriteLine($"El resultado de la suma es: {calcuB.Sumar()}");
                calcuB.Sumar(num1); // Llamada al método sobrecargado
                calcuB.Sumar(num2); // Llamada al método sobrecargado
                calcuB.Sumar(num1 + num2); // Llamada al método sobrecargado

                break;
            case 2:
                Console.WriteLine($"El resultado de la resta es: {calcuB.Restar()}");
                break;
            case 3:
                Console.WriteLine($"El resultado de la multiplicación es: {calcuB.Multiplicar()}");
                break;
            case 4:
                calcuB.Dividir();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
        break;
    case 2:
        CalculadoraCientifica calcuC = new CalculadoraCientifica(num1, num2);
        Console.Write("Has seleccionado la Calculadora Científica.");
        Console.Write("Has seleccionado la Calculadora Básica.");
        Console.WriteLine("Selecciona la operación a realizar:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Factorial (del primer número)");
        Console.WriteLine("6. Raíz Cuadrada (del primer número)");
        Console.WriteLine("7. Logaritmo Natural (del primer número)");
        calcuC.MensajeCalculadora();
        int opcionC = int.Parse(Console.ReadLine() ?? "");
        switch (opcionC)
        {
            case 1:
                Console.WriteLine($"El resultado de la suma es: {calcuC.Sumar()}");
                break;
            case 2:
                Console.WriteLine($"El resultado de la resta es: {calcuC.Restar()}");
                break;
            case 3:
                Console.WriteLine($"El resultado de la multiplicación es: {calcuC.Multiplicar()}");
                break;
            case 4:
                calcuC.Dividir();
                break;
            case 5:
                Console.WriteLine($"El resultado del factorial es: {calcuC.Factorial()}");
                break;
            case 6:
                Console.WriteLine($"El resultado de la raíz cuadrada es: {calcuC.RaizCuadrada()}");
                break;
            case 7:
                Console.WriteLine($"El resultado del logaritmo natural es: {calcuC.Logaritmo()}");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
        break;
    default:
        Console.Write("Opción no válida");
        break;

}
if(tipoCalculadora == 1)
{
    Calculadora calcu = new Calculadora(num1, num2);
}
else
{
    CalculadoraCientifica calcu = new CalculadoraCientifica(num1, num2);
}

//Instanciar el objeto

//Calculadora calcu = new Calculadora(num1, num2);

//Seleccion de la operacion
*/

