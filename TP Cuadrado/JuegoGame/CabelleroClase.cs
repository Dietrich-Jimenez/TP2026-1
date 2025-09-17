public class Caballero : Guerrero
{
    //Constructor
    public Caballero (string nombre) : base (nombre, 120,20)
    {
    }
    //ovverride del metodo atacar
    public override void Atacar(Guerrero enemigo)
    {
        Console.WriteLine($"{Nombre} carga con su lanza hacia {enemigo.Nombre}!");
        base.Atacar(enemigo);

    }
}