using System.Security.Cryptography.X509Certificates;

public class Inventario
{
    //Atributos
    private Suministro[] suministros;
    //Constructor
    public Inventario()
    {
        suministros = new Suministro[]
        {
            new Suministro("Comida", 5, 1),
            new Suministro("Agua",10,1),
            new Suministro("Ropa",7,2),
            new Suministro("Antibioticos",0,1),
            new Suministro("Herramientas"),
            new Suministro("Oxígeno"),
            new Suministro("Combustible"),

        };
    }

    //Metodos
    public void MostrarSuministros()
    {
        Console.WriteLine("Inventario actual");
        foreach(Suministro item in suministros)
        {
            item.MostrarInfo();
        }
    }
    public void BuscarSuministro(string nombre)
    {
        int indice = Array.FindIndex(suministros, s => s.Nombre.ToLower() == nombre.ToLower());
        if (indice >= 0)
        {
            Console.WriteLine($"{nombre} encontrado en la posición del {indice}");
        }
        else
        {
            Console.WriteLine($"{nombre} no está en el inventario");
        }
    }
    public void OrdenarPorNombre()
        {
            Array.Sort(suministros,(x,y) => x.Nombre.CompareTo(y.Nombre));
        }
    //Invertir el orden
    public void InverirOrden()
    {
        Array.Reverse(suministros);
        Console.WriteLine("El orden de los suministro invertido");
    }
    //Vaciar inventario
    public void VaciarInventario()
    {
        Array.Clear(suministros,0,suministros.Length);
        Console.WriteLine("Inventario borrado");
        Console.WriteLine($"Longitud: {suministros}");
    }//Agregar sumnistro 3 parametros
    public void AgregarSuministros(string nombre, int cantidad, int prioridad)
    {
        int indice = Array.FindIndex(suministros, s => s.Nombre.ToLower() == nombre.ToLower());
        if (indice >= 0)
        {
            Console.WriteLine($"{nombre} ya existe en el inventario");
            Console.WriteLine($"{nombre} encontrado en la posición del {indice}");
        }
        else
        {
            Array.Resize(ref suministros, suministros.Length + 1);
            suministros[suministros.Length - 1] = new Suministro(nombre, cantidad, prioridad);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{nombre} se ha agregado en el inventario");
        }
    }

        //Agregar suministro con nombre
     public void AgregarSuministros(string nombre)
        {
        AgregarSuministros(nombre, 1, 2);
        }
    public void EliminarSuministro(string nombre)
    {
        int indice = Array.FindIndex(suministros, s => s.Nombre.ToLower() == nombre.ToLower());
        if (indice >= 0)
        {
            for (int i = indice; i < suministros.Length - 1; i++)
            {
                suministros[i] = suministros[i + 1];
            }
            Array.Resize(ref suministros, suministros.Length - 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{nombre} se eliminó");
            

        }
        else
        {
            Console.WriteLine($"{nombre} no está en el inventario");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
    }

    }

