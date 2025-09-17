//Programa principal
Perro miPerro = new Perro();
miPerro.Respirar();
miPerro.HacerSonido();



public class Animal
{
    //Metodos del padre
    public void Respirar()
    {
        Console.WriteLine("Respirando");
    }
    //herencia con polimorfismo
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");

    }
}
public class Perro : Animal
{
    //sobreescritura del metodo del padre
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra");
    }
}
public class Gato : Animal
{
    //sobreescritura del metodo del padre
    public override void HacerSonido()
    {
        Console.WriteLine("El gato maulla");
    }
}