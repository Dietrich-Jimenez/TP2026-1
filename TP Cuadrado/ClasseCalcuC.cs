public class CalculadoraCientifica : Calculadora
{
    //Atributos
    public CalculadoraCientifica (double num1, double num2) : base(num1, num2)
    {
    }
    //Metodos
    public override double Sumar()
    {
        double suma = base.Sumar();
        Console.WriteLine($"El resultado de la suma es: {suma*2}");
        return suma;

    }

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
    public double RaizCuadrada()
    {
        return Math.Sqrt(numero1);

    }
    public double Logaritmo()
    {
        return Math.Log(numero1);
    }
    public void MensajeCalculadora()
    {
        Console.WriteLine(MostrarMensaje());
    }
}