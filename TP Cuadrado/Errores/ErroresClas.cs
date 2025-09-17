int numero;
Console.WriteLine("Este programas solo divide 10 entre un numero positivo y  negativo");


//Estas cosas son por si el usuario está todo wey y sirve para evitar errores en el programa
try
{
    numero = int.Parse(Console.ReadLine() ?? "");
    if (numero <0)
    {
        throw new AggregateException("El numero no puede ser negativo");
    }
    double division = 10 / numero;
    Console.WriteLine($"Division: {division}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir entre 0");
}
catch(FormatException)
{
    Console.WriteLine("El numero ingresado no existe");
}
catch (AggregateException)
{
    Console.WriteLine("El numero no puede ser negativo");
}
catch(Exception ex )
{
    Console.WriteLine($"Error inesperado {ex.Message}");
}
finally
{
    Console.WriteLine("El programa terminó");
}