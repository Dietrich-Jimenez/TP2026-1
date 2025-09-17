//Sistema para una agencia de autos <3


public class Auto : Vehiculo
{
    //Constructor
    public Auto(string marca, string modelo) : base(marca, modelo)
    {
    }
    public override void MostrarInfo()
    {
        Console.WriteLine($"Auto: {modelo}, {marca}, {velocidadactual}[km/h]");
    }
}
        