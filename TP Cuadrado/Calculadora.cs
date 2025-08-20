public class Calculadora
{
    // Atributos
    public double numero1;
    public double numero2;
    // Constructor
    public Calculadora(double num1, double num2)
    {
        numero1 = num1;
        numero2 = num2;
    }
    // Métodos
    public double Sumar()
    {
        return numero1 + numero2;
    }
    public double Restar()
    {
        return numero1 - numero2;
    }
    public double Multiplicar()
    {
        return numero1 * numero2;
    }
    public void Dividir()
        {
        if(numero2 != 0)
        {
            Console.WriteLine($"El resultado de la división es: {numero1 / numero2}");
        }
        else
        {
            Console.WriteLine("Error: División por cero no permitida.");
        }
    }

}