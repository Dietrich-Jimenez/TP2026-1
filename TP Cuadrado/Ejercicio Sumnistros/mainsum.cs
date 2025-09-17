//Programa pincipal del inventario Mision Espacial

//Instancias inventario

Inventario inventario = new Inventario();
bool salir = false;

do
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nSuministros de la nave:");
    Console.WriteLine("1-Agregar Suministro");
    Console.WriteLine("2-Buscar suministros");
    Console.WriteLine("3-Eliminar suministros");
    Console.WriteLine("4-Mostrar inventario");
    Console.WriteLine("5-Limpiar inventario");
    Console.WriteLine("6-Salir");
    int opcion = int.Parse(Console.ReadLine()??"");
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Escribe el nombre del suministro a agregar:");
            string nombre = Console.ReadLine() ?? "";
            if(nombre != "")
            {
                Console.WriteLine("Quieres asignar cantidad y prioridad");
                Console.WriteLine("1- Sí \n 2-No");
                int opAS = int.Parse(Console.ReadLine() ?? "");
                switch(opAS)
                {
                    case 1:
                        Console.WriteLine("Escribir la cantidad");
                        int cantidad = int.Parse(Console.ReadLine() ?? "");
                        Console.WriteLine("Escribir la prioridad");
                        int prioridad = int.Parse(Console.ReadLine() ?? "");
                        inventario.AgregarSuministros(nombre, cantidad, prioridad);
                        break;
                    case 2:
                        inventario.AgregarSuministros(nombre);

                        break;
                    default:
                        Console.WriteLine("Esa opción no es válida");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Nombre no válido");
            }
                break;
        case 2:
            Console.WriteLine("Escribir el nombre del suministro a buscar");
            string nombreB = Console.ReadLine() ?? "";
            inventario.BuscarSuministro(nombreB);
            break;
        case 3:
            Console.WriteLine("Escribir el nombre del suministro a eliminar");
            string nombreC = Console.ReadLine() ?? "";
            inventario.EliminarSuministro(nombreC);
            break;
        case 4:
            inventario.MostrarSuministros();
            break;
        case 5:
            inventario.VaciarInventario();
            break;
        case 6:
            Console.WriteLine("Opción no válida");
            break;
    }
}
while (!salir);