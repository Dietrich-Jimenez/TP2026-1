using static System.Runtime.InteropServices.JavaScript.JSType;

public class CalculadoraCientifica : Calculadora
{
    //Atributos
    public CalculadoraCientifica (double num1, double num2) : base(num1, num2)
    {
    }
    //Metodos
    public int Factorial()
    {
        if (numero1 < 0)
        {
            Console.WriteLine("No se puede calcular el factorial de un número negativo.");
            return 0; // Indica un error
        }
        int resultado = 1; 
        for (int i = 1; i <= numero1; i++)
        {
            resultado *= i;
        }
        Console.WriteLine($"El factorial de {numero1} es: {resultado}");
        return resultado;


    }
}