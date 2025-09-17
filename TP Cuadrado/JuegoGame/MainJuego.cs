//Programa principal del juego

try
{
    Console.WriteLine("Bienvenido a la guerra del infinito");
    //Obtener nombre del guerrero
    string nombre = ObtenerNombre();
    //Seleccionar clase del guerrero
    Guerrero jugador = SeleccionarClase(nombre);
    //Generar enemigo aleatorio
    Guerrero enemigo = GenerarEnemigo();
    Console.WriteLine($"Te vas a enfrentar {enemigo.Nombre} con {enemigo.Salud} de vida y {enemigo.Ataque} de ataque.");

    while (jugador.Salud > 0 && enemigo.Salud > 0)
    {
        enemigo.Atacar(jugador);
        MostrarEstado(jugador, enemigo);
        int opcion = ObtenerOpcion();
        if (opcion == 1)
        {
            jugador.Atacar(enemigo);
            if (enemigo.Salud > 0) ;
        }
        else if (opcion == 2)
        {
            int proba = new Random().Next(0, 100);
            if (proba < 40) //60% de probabilidad de fusionar
            {
                Console.WriteLine("La fusión ha fallado, el enemigo aprovecha para atacar!");
                jugador.RecibirDagno((int)(jugador.Salud * 0.1f));

            }
            else
            {
                jugador = jugador + enemigo;
                Console.WriteLine($"Tu fsioón salió bien, eres un nueo fierraro.");
                enemigo.Salud = 0; //Para salir del bucle
            }
        }
        else
        {
            throw new ArgumentException("Opción inválida. Inténtalo de nuevo.");
        }
        if(enemigo.Salud > 0)
        {
            enemigo.Atacar(jugador);
        }
    }
    Console.WriteLine(jugador.Salud > 0 ? "¡Felicidades! Has derrotado al enemigo." : "Has sido derrotado.");
}
catch (Exception ex)
{
    Console.WriteLine($"Ha ocurrido un error inesperado: {ex.Message}");
}
finally
{
    Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
}
{

}
    




static string ObtenerNombre()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Ingrese el nombre de su guerrero:");
            string nombre = Console.ReadLine() ?? "".Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacío. Inténtalo de nuevo.");
            }
            //Evitar nombres con caracteres especiales o numeros
            else if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                throw new ArgumentException("El nombre solo puede contener letras y espacios. Inténtalo de nuevo.");
            }
            else
            {
                // ??
                return nombre;

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ingresar el nombre. Inténtalo de nuevo.");
            Console.WriteLine(ex.Message);
        }

    }

}
//Funcion del menú
static int ObtenerOpcion()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Selecciona la opción");
            int opcion = int.Parse(Console.ReadLine() ?? "0");
            if (opcion != 1 && opcion !=2)
            {
                throw new ArgumentException("Opción inválida. Inténtalo de nuevo.");

            }
            return opcion;
        }
        catch (Exception ex)
        {
            Console.WriteLine($" Error al seleccionar opción. {ex.Message} ");
        }
    }
}
//Funcion para seleccionar clase
static Guerrero SeleccionarClase(string nombre)
{
    while (true)
    {
        try
        {
            Console.WriteLine("Selecciona la clase de tu guerrero:");
            Console.WriteLine("1. Caballero (Alta salud y ataque moderado)");
            Console.WriteLine("2. Arquero (Salud baja pero con posibilidad de fallar ataques)");
            Console.WriteLine("3. Guerrero Sombra (Salud y ataque equilibrados con posibilidad de esquivar ataques)");
            Console.WriteLine("4. Mago (Ataque alto pero salud muy baja)");
            int opcion = int.Parse(Console.ReadLine() ?? "0");
            return opcion switch
            {
                1 => new Caballero(nombre),
                2 => new Arquero(nombre),
                3 => new GuerreroSombra(nombre),
                4 => new Mago(nombre),
                _ => throw new ArgumentException("Opción inválida. Inténtalo de nuevo.")
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al seleccionar clase. {ex.Message}");
        }
    }
}
//Funcion para crear enemigo aleatorio
static Guerrero GenerarEnemigo()
{
    string[] nombres = { "Goblin", "Herobrine", "Thanos", "Jeff the killer", "Esqueleto","Sexofanio.exe" };
    string nombre = nombres[new Random().Next(nombres.Length)];
    int[] vidas = { 80, 120, 200, 110, 90,210 };
    int vida = vidas[new Random().Next(vidas.Length)];
    int[] ataques = { 10, 25, 30, 20, 12,30 };
    int ataque = ataques[new Random().Next(ataques.Length)];

    return new Guerrero(nombre, vida, ataque);
}
//Funcion de mostrar estado
static void MostrarEstado(Guerrero jugador, Guerrero enemigo)
{
    Console.WriteLine($"Tu vida {jugador.Salud}| Vida del enemigo {enemigo.Salud}");
    Console.WriteLine("1) Atacar");
    Console.WriteLine("2) Fusionar con el enemigo");

}

