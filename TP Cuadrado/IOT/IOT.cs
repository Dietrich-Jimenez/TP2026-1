//Programa principal
List<IDispositivoInteligente> dispositivos = new List<IDispositivoInteligente>
{
    new Lampara(),
    new Ventilador(),
    new Altavoz()
}
;
//Encender todos los dispositivos
foreach (var dispositivo in dispositivos) //Lo declacomo var porque no se cual de los 3 va a ser
{
    dispositivo.Encender();
    dispositivo.MostrarEstado();
}
//Interactuar con los dispositivos
Console.WriteLine("Ajustar configuraciones específicas:");
((Lampara)dispositivos[0]).AjustarBrillo(75);
((Ventilador)dispositivos[1]).AjustarVelocidad(3);
((Altavoz)dispositivos[2]).ReproducirMusica("40 y 20 - José José");
//Mostrar estadoa actual
Console.WriteLine("Estado actualizado");
foreach (var dispositivo in dispositivos)
{
    dispositivo.MostrarEstado();
}
//Apagar todos los dispositivos
foreach (var dispositivo in dispositivos)
{
    dispositivo.Apagar();
    dispositivo.MostrarEstado();
}

//Interfaz
interface IDispositivoInteligente
{
    void Encender();
    void Apagar();
    void MostrarEstado();

}

//Clases
public class Lampara : IDispositivoInteligente
{
    //Atributos
    private bool encendida = false;
    private int brillo = 50; // Brillo inicial al 50%, en lumens
    //Metodos
    public void Encender()
    {
        encendida = true;
        Console.WriteLine("La lámpara está encendida.");
    }
    public void Apagar()
    {
        encendida = false;
        Console.WriteLine("La lámpara está apagada.");
        brillo = 0;
    }
    public void MostrarEstado()
    {
        Console.WriteLine($"Estado de la lámpara: {(encendida ? "Encendida" : "Apagada")}, Brillo: {brillo}%");
    }
    public void AjustarBrillo(int nivel)
    {
        if (nivel <0 || nivel>100)
        {
            Console.WriteLine("El nivel de brillo debe estar entre 0 y 100.");
            return;
        }
        brillo = nivel;
        Console.WriteLine($"Brillo ajustado a {brillo}%.");

    }
    
   
}
public class Altavoz : IDispositivoInteligente
{
    //Atributos
    private bool encendida = false;
    private string cancionActual = "Ninguna";
    //Metodos
    public void Encender()
    {
        encendida = true;
        Console.WriteLine("El altavoz está encendida.");
    }
    public void Apagar()
    {
        encendida = false;
        Console.WriteLine("El altavoz está apagada.");
        cancionActual = "Ninguna";
    }
    public void MostrarEstado()
    {
        Console.WriteLine($"Estado del altavoz: {(encendida ? "Encendida" : "Apagada")}, Reproduce: {cancionActual}%");
    }
    public void ReproducirMusica(string cancion)
    {
        cancionActual = cancion;
        Console.WriteLine($"{(encendida ? $"Reproduciendo: {cancionActual}" : "Reproduciendo nada")}");
    }
}
public class Ventilador : IDispositivoInteligente
{
    //Atributos
    private bool encendida = false;
    private int velocidad = 1; // Velocidad inicial al 1, en niveles del 1 al 5
                               //Metodos
    public void Encender()
    {
        encendida = true;
        Console.WriteLine("El ventilado está encendido.");
    }
    public void Apagar()
    {
        encendida = false;
        Console.WriteLine("El ventilador está apagado.");
        velocidad = 0;
    }
    public void MostrarEstado()
    {
        Console.WriteLine($"Estado del ventilador: {(encendida ? "Encendida" : "Apagada")}, Velodicad: {velocidad}%");
    }
    public void AjustarVelocidad(int nivel)
    {
        velocidad = Math.Clamp(nivel, 1, 5);
        Console.WriteLine($"Velocidad ajustada a {velocidad}.");

    }
}