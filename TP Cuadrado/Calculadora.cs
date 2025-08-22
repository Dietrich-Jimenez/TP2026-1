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
    //Atributo privado
    private double Resultado;
    private string Mensaje = "Mensaje privado";
    // Métodos
    public virtual double Sumar()
    {
        Resultado = numero1 + numero2;
        Console.WriteLine($"El resultado de la suma es: {Resultado}");

        return Resultado;
    }
    public double Sumar(double num3)
    {
        
        Console.Write($"El resultado de la suma con el número adicional es: {Resultado}");
        return Resultado = numero1 + numero2 + num3;

    }

    public static Calculadora operator + (Calculadora c1, Calculadora c2)
    {
        return new Calculadora(c1.numero1+c2.numero2,c1.numero2+c2.numero1);

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
            Console.WriteLine("No hay división entre 0.");
        }
    }
    //Metodo privado
    protected string MostrarMensaje()
    {
        Console.WriteLine(Mensaje);
        return Mensaje;
    }
    //Metodo para acceder al metodo protegido de la clase base   
}