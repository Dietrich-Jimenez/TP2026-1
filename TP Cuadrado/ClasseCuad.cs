//Herencia El cuadrado heredará del rectángulo
public class Cuadrado : Rectangulo
{
    //Lado es tanto la base como la altura
    //Constructor para el cuadrado
    public Cuadrado(double lado): base(lado, lado)
    {

    }
    //Metodos, sobreescribir los heredados del Rectangulo
    public override double CalcularArea()
    {
        return Base * Base;
    }
    public override double Perimetro()
    {
        return 4 * Base;
    }
}