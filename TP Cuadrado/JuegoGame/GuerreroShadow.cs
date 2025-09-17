public class GuerreroSombra : Guerrero
{
    //Constructor
    public GuerreroSombra(string nombre) : base(nombre, 110, 22)
    {
    }

    //Override de ataque
    public override void Atacar(Guerrero enemigo)
    {
      Console.WriteLine($"{Nombre} ataca sigilosamente a {enemigo.Nombre}!");
        base.Atacar(enemigo);
    }
    //Override de recibir daño con probabilidad de esquivar
    public override void RecibirDagno(int dagno)
    {
        int probabilidad = new Random().Next(0,100);
      
        if (probabilidad <= 20) //Posibilidad de esquivar 20%
        {
            Console.WriteLine($"{Nombre} esquivó el ataque!");
        }
        else
        {
            base.RecibirDagno(dagno);
        }
    }
}