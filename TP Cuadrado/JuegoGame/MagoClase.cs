public class Mago : Guerrero
{
    //Constructor
    public Mago(string nombre) : base(nombre, 80, 25)
    {
    }

    //override del metodo atacar
    public override void Atacar(Guerrero enemigo)
    {
        Console.WriteLine($"{Nombre} lanza un hechizo de fuego hacia {enemigo.Nombre}!");
        base.Atacar(enemigo);
    }


}