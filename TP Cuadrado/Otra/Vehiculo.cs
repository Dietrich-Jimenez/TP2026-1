using System.Runtime.Intrinsics;

public class Vehiculo
{
    //Atributos
    /*
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int VelocidadActual { get; set; }
    */

    //Atributos privados  --> para que no se modifiquen

    protected string marca;
    protected string modelo;
    protected int velocidadactual;

    //Propiedads pblicas con control
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }
    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }
    public int VelocidadActual
    {
        get { return velocidadactual; }
        private set
        {
            if (velocidadactual < 0)
            {
                velocidadactual = 0;
            }
            else
            {
                velocidadactual = value;
            }
        }
    }
    //Constructor

    public Vehiculo(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.velocidadactual = 0;
    }

    //Métodos
    public void Acelerar(int incremento)
    {
        // VelocidadActual += incremento; //VelocidadActual = VelocidadActual + incremento
        VelocidadActual = VelocidadActual + incremento;
    }
    public void Acelerar()
    {
        VelocidadActual = VelocidadActual + 10;
    }
    public void Frenar(int decremento)
    {
        VelocidadActual = VelocidadActual - decremento;
    }
    public void Frenar()
    {
        VelocidadActual = VelocidadActual - 10;
    }
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Vehículo: {marca},{modelo}, Velocidad {velocidadactual}");
    }
    //Sobrecarga de operadores
    public static bool operator >(Vehiculo v1, Vehiculo v2)
        {
        return v1.velocidadactual > v2.velocidadactual;
        }
    public static bool operator <(Vehiculo v1, Vehiculo v2)
    {
        return v1.velocidadactual < v2.velocidadactual ;
    }
    public static bool operator == (Vehiculo v1, Vehiculo v2)
    {
        return v2.velocidadactual == v1.velocidadactual ;
    }
    public static bool operator != (Vehiculo v1, Vehiculo v2)
    {
        return v1.velocidadactual != v2.velocidadactual ;
    }

}