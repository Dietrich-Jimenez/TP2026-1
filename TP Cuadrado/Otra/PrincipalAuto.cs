//Programa principal
Auto auto1 = new Auto("Honda","Civic");


Console.WriteLine($"Auto : {auto1.Marca}, {auto1.Modelo}, Velocidad: {auto1.VelocidadActual} km/h");

auto1.Acelerar(100);
Console.WriteLine($"El auto aceleró: {auto1.VelocidadActual}km/h");
auto1.Acelerar();
auto1.MostrarInfo();
auto1.Frenar(20);
Console.WriteLine($"El auto frenó: {auto1.VelocidadActual} km/h");
auto1.Frenar();
auto1.MostrarInfo();
Moto moto1 = new Moto("Yamaha", "MT07");
Console.WriteLine($"Moto : {moto1.Marca}, {moto1.Modelo}, Velocidad: {moto1.VelocidadActual} km/h");
moto1.Acelerar(40);
Console.WriteLine($"La moto aceler+o: {moto1.VelocidadActual}km/H");
moto1.MostrarInfo();
moto1.Frenar(20);
Console.WriteLine($"La moto frenó: {moto1.VelocidadActual} km/h");
moto1.MostrarInfo();


if (auto1>moto1)
{
    Console.WriteLine($"La velocidad de {auto1} es mayor a {moto1}");
}
else if (auto1<moto1)
{
    Console.WriteLine($"La velocidad de {moto1} es mayor a {auto1}.");

}
else if (auto1==moto1)
{
    Console.WriteLine($"La velocidad de {auto1} es iugal a {moto1}");
}