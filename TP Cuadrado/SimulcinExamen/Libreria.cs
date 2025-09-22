//Simulación de examen
//Programa principal

//Instancias de la librería

Libreria libreria = new Libreria();
try
{
    Console.WriteLine("Ingrese el número de operaciones:");
    int operaciones = int.Parse(Console.ReadLine()??"");
    for (int i =0; i <operaciones; i++)
    {
        //Sin aplicar expresiones regulares
        string[] entrada = (Console.ReadLine()??"").Split(' '); //el .Split(' ') divide la cadena en un array de cadenas, la corta con algun caracter
        string comando = entrada[0];
        switch (comando)
        {
            case "Libro":
                libreria.AgregarLibro(entrada[1], entrada[2], entrada[3]);
                break;
            case "Calificar":
                if(entrada.Length == 4)
                {
                    libreria.CalificarLibro(entrada[1], int.Parse(entrada[3]), "");
                }
                else if (entrada.Length == 5)
                {
                    libreria.CalificarLibro(entrada[1], int.Parse(entrada[3]), string.Join("", entrada.Skip(4)));
                }
                break;
            case "Mejor":
                libreria.MostrarMejorLibr(entrada[1]);

                break;
            case "Criterio":
                libreria.CambiaCriterio(entrada[1]);
                break;
            default:
                throw new InvalidOperationException("Comando no válido");

        }
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


public class Libro
{
    //Atributos
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    protected List<int> calificaciones;
    //Constructor
    public Libro(string titulo, string autor, string genero)
    {
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
        calificaciones = new List<int>();

    }
    //Metodos
    public void Calificar(int nota)
    {
        if (nota > 1 || nota < 10)
        {
            throw new ArgumentException("La nota debe estar entre 1 y 5");
        }
        calificaciones.Add(nota);
    }
    //Sobrecarga de metodos
    public void Calificar(int nota, string comentario)
    {
        Console.WriteLine($"Comentario: {comentario}");
        Calificar(nota);
    }
    public double ObtenerPromedio()
    {
        if (calificaciones.Count == 0)
        {
            return 0;
        }
        double suma = 0;
        foreach (int calificacion in calificaciones)
        {
            suma += calificacion;
        }
        return suma/ calificaciones.Count;
    }
    public int ObtenerCantidadVotos()
    {
        return calificaciones.Count;
    }
}
//Subclase para las diferentes categorias de libros
public class LibroFiccion : Libro
{
    public LibroFiccion(string titulo, string autor,string genero) : base(titulo, autor, "Ficción")
    {}
}
public class LibroTecnico : Libro
{
    public LibroTecnico(string titulo, string autor, string genero) : base(titulo, autor, "Técnico")
    {}
}
//Interfaz para la selección de estrategia de recomendación
interface IRecomendable
{
    Libro ObtenerMejorLibro(List<Libro>libros);
}
//Estrategia basada en la calificación promedio
public class RecomendacionPorCalificacion : IRecomendable
{
    public Libro ObtenerMejorLibro(List<Libro> libros)
    {
        Libro mejorLibro = null;
        double MerjorPromedio = -1;
        foreach (var libro in libros)
        {
            double promedio = libro.ObtenerPromedio();
            if (promedio > MerjorPromedio)
            {
                MerjorPromedio = promedio;
                mejorLibro = libro;
            }
        }
        return mejorLibro;
    }
}
//Estrategia basada en la cantidad de votos
public class RecomendacionPorVotos : IRecomendable
{
    public Libro ObtenerMejorLibro(List<Libro> libros)
    {
        Libro mejorLibro = null;
        int maximaCantidadVotos = -1;
        foreach (var libro in libros)
        {
            int cantidadVotos = libro.ObtenerCantidadVotos();
            if (cantidadVotos > maximaCantidadVotos)
            {
                maximaCantidadVotos = cantidadVotos;
                mejorLibro = libro;
            }
        }
        return mejorLibro;
    }
}
//Clase para librería
public class Libreria
{
    private List<Libro> libros = new List<Libro>();
    private IRecomendable estrategiaRecomendacion = new RecomendacionPorCalificacion();
    private readonly string[] generoFiccion = { "Ficción", "Novela", "Fantasía", "Terror" };
    private readonly string[] generoTecnico = { "Programación", "Termodinámica", "Mecánica", "Matemátcas" };
  //Métodos de mi librería
  public void AgregarLibro(string titulo, string autor, string genero)
    {
        if (generoFiccion.Contains(genero))
        {
            libros.Add(new LibroFiccion(titulo, autor, genero));
        }
        else if (generoTecnico.Contains(genero))
        {
            libros.Add(new LibroTecnico(titulo, autor, genero));
        }
        else
        {
            throw new ArgumentException("Género no válido");
        }
    }
    //Sobrrecarga de métodos para calificar libro
    public void CalificarLibro(string titulo, int nota,string comentario)
    {
        Libro libroEncontrado = null;
        foreach (var libro in libros)
        {
            if (libro.Titulo == titulo)
            {
                libroEncontrado = libro;
                break;
            }
        }
        if (libroEncontrado == null)
        {
            throw new KeyNotFoundException("Libro no encontrado");
        }
        else if (libroEncontrado != null)
        {
            libroEncontrado.Calificar(nota,comentario);
        }
    }
    //Criterio de calificación
    public void CambiaCriterio(string criterio)
    {
        if (criterio == "Calificación")
        {
            estrategiaRecomendacion = new RecomendacionPorCalificacion();
        }
        else if (criterio == "Votos")
        {
            estrategiaRecomendacion = new RecomendacionPorVotos();
        }
        else
        {
            throw new ArgumentException("Criterio no válido");
        }
    }
    //Mejor libro
    public void MostrarMejorLibr(string genero)
    {
        List <Libro> librosGenero = new List<Libro>();
        foreach (var libro in libros)
        {
            if (libro.Genero == genero)
            {
                librosGenero.Add(libro);
            }
        }
        var mejorLibro = estrategiaRecomendacion.ObtenerMejorLibro(librosGenero);
        if (mejorLibro != null)
        {
            Console.WriteLine(mejorLibro .Titulo);
        }
        else
        {
            Console.WriteLine("No hay libros en este género");
        }
    }

}


