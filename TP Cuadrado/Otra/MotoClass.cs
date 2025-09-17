public class Moto : Vehiculo
{
    //Constructor
    public Moto(string marca, string modelo) : base(marca, modelo)
    {
    }
    //Metodo
    public override void MostrarInfo()
    {
        Console.WriteLine($"Moto: {marca}, {modelo}, {velocidadactual} [km/h]");
    }
}
