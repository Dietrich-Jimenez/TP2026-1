//Lista
//Crear una lista
/*
List<int> numeros = new List<int>();
List<string> nombres = new List<string>();
//Agregar elementos
numeros.Add(10);
numeros.Add(20);
numeros.Add(30);
//Acceder a elementos
int primerNumero = numeros[0];
Console.WriteLine($"El primer numero es: {primerNumero}");
numeros.Remove(10);
numeros.RemoveAt(1);
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
*/
//Programa lista de personas
List<Persona> personas = new List<Persona>();
personas.Add(new Persona("Juan", 25));
personas.Add(new Persona("Ana", 30));
personas.Add(new Persona("Luis", 28));
personas.Add(new Persona("Maria", 10));
personas.Add(new Persona("Carlos", 15));

Console.WriteLine("Personas mayores de edad:");
foreach (Persona persona in personas)
{
    if (persona.Edad >= 18)
    {
        persona.MostrarInformacion();
    }

}
int[] numeros = new int[] { 5, 3, 8, 1, 2 };
numeros[1] = 10;