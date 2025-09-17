//Programa principal
IEjemplo algo = new EjemploClase();
algo.HacerAlgo();
algo.HacerAlgoMas();

EjemploClase otraCosa = new EjemploClase();
otraCosa.HacerAlgo();
otraCosa.HacerAlgoMas();

//Interfaz
public interface IEjemplo
{
    //Metodo de la interfaz (contratos)
    void HacerAlgo();
    //Metodo ya definido
    void HacerAlgoMas()
    {
        Console.WriteLine("Haciendo algo más...");
    }

}
//Clase que implementa la interfaz
public class EjemploClase : IEjemplo
{
    public void HacerAlgo()
    {
        Console.WriteLine("Haciendo algo...");
    }
    public void HacerAlgoMas()
    {
        Console.WriteLine("Haciendo algo más...");
    }
}