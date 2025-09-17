public class Arquero : Guerrero
{
    //Constructor
    public Arquero(string nombre) : base(nombre, 90, 15)
    {
    }
    //override del metodo atacar

    //Probabilidad de fallar el ataque
    public override void Atacar(Guerrero enemigo)
    {
        int probailidad = new Random().Next(0,100);
       
        if (probailidad <= 30) // 30% de probabilidad de fallar
        {
            Console.WriteLine($"{Nombre} falló el tiro!");
        }
        else
        {
            Console.WriteLine($"{Nombre} dispara una flecha hacia {enemigo.Nombre}!");
            base.Atacar(enemigo);
        }

    }
}
