//Interfaz ANimal
interface IAnimal
{
    //Metodo para hacer sonido
    void HacerSonido();
}
interface IVolador
{
    //Metodo para volar
    void Volar();
}
public class Pajaro : Animal, IAnimal, IVolador
{
    public void HacerSonido()
    {
        Console.WriteLine("El pájaro canta");
    }
    public void Volar()
    {
        Console.WriteLine("El pájaro vuela");
    }
}