public class Persona
{
    //Atributos
    public string Nombre { get; set; }
    public int Edad{ get; set; }
    
    //Constructor
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    //Métodos
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }

}