public class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }


    public Rectangulo(double basse, double altura)
    {
        Base = basse;
        Altura = altura;
    }
    public virtual double CalcularArea()
    {
        return Base * Altura;
    }
    public virtual double Perimetro()
    {
        return 2 * (Base + Altura);
    }
}
