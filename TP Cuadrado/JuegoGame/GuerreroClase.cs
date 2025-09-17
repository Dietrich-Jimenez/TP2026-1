public class Guerrero
{
    //Atributos
    public string Nombre { get; set; }
    public int Salud { get; set; }
    public int Ataque { get; set; }


    //Constructor
    public Guerrero(string nombre, int salud, int ataque)
    {
        Nombre = nombre;
        Salud = salud;
        Ataque = ataque;
    }
    //Metodos
    public virtual void Atacar(Guerrero enemigo)
    {
        int dagno = Ataque + new Random().Next(-3,5);
        enemigo.RecibirDagno(dagno);
        Console.WriteLine($"{Nombre} ataca a {enemigo} con {dagno} de daño.");
    }
    public virtual void RecibirDagno(int dagno)
    {
        Salud = Math.Max(Salud - dagno, 0);
        Console.WriteLine($"{Nombre} recibe {dagno} de daño. Salud restante: {Salud}");
    }
    public static Guerrero operator + (Guerrero g1, Guerrero g2)
    {
        Console.WriteLine($"Se ha unido {g1.Nombre} con {g2.Nombre}");
        return new Guerrero($" {g1.Nombre}+{g2.Nombre}", (g1.Salud + g2.Salud)/2, (g1.Ataque + g2.Ataque)/2  );
    }

}