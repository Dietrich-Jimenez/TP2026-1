
int numero = 0;
Console.WriteLine("Ingresa el numero natural:");

numero = int.Parse(Console.ReadLine()??"");

if (numero == 0)
{
    Console.WriteLine("Es 1");
}
else if (numero > 0)
{
    for (int i = numero - 1; i >= 1; i--)
    {
        numero = numero * i;
    }
    Console.Write($"El factorial es: {numero}");
}
else
{
    Console.WriteLine("No se puede calcular");
}

//else
//{
//  Console.WriteLine("No es ninguno");
//}
//If
//For
//for(int i = 1; i > 9; i++)
//{
//  Console.WriteLine(i);
//}

