Console.WriteLine("Hola mundo");
Console.Write("Ingresa el nombe de la persona");
    string nombre = Console.ReadLine() ?? "";

Console.WriteLine("Ingresar la edad");
    int edad = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el pais de origen");
    string pais = Console.ReadLine()??"";

//Mostrar datos
Console.WriteLine("Los datos de la persona son");
Console.WriteLine($"Nombre:{nombre}");
Console.WriteLine($"Edad:{edad}");
Console.WriteLine($"Pais de origen:{pais} ");
//Programa OO
//Crear objetvo de tipo persona
Persona.Pais = "Tierra";
Persona unEnteAlie = new Persona("Alien", 580);

//Console.Write ("Nombre");
//Console.WriteLine(unEnteAlie.Name);
//Console.Write("Edad");
//Console.Write(unEnteAlie.Edad);
//Console.Write("Pais");
//Console.WriteLine(unEnteAlie.Pais);

//Ejecutar el metodo de persona
unEnteAlie.MostrarDatos();
//unEnteAlie.MostrarPais();

Persona humano = new Persona("Juan", 20);
humano.MostrarDatos();
Persona.MostrarPais();

//humano.MostrarPais();