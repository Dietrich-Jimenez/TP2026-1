//Programa principal de casteos

//Conversión implicita

int numero = 42;
double numDouble = numero; // Conversión implícita de int a double

Console.WriteLine(numDouble); // Salida: 42

//Conversión explicita
double numDouble2 = 42.58;
int numEntero2 = (int)numDouble; // Conversión explícita de double a int

Console.WriteLine(numEntero2); // Salida: 42

//Con metodos de conversión
string texto = "123";
int numero3 = Convert.ToInt32(texto); // Conversión de string a int
Console.WriteLine(numero3+1); // Salida: 123

//Parse
string texto2= "3.14159";
double numDoube3 = double.Parse(texto2); // Conversión de string a double
Console.WriteLine(numDoube3+1); // Salida: 4.14159, si el string no es un número válido, lanza una excepción

//Try para evitar errores
string texto3 = "555";
int resultado;
bool exito = int.TryParse(texto3, out resultado); // Intenta convertir el string a int
Console.WriteLine(exito);
Console.WriteLine(resultado); // Salida: False, 0 si la conversión falla
                              // Si la conversión es exitosa, 'exito' será true y 'resultado' contendrá el valor convertido

//Casteo entre objetos y clases
Animal miAnimal = new Orangutan();
miAnimal.HacerSonido(); // Salida: El animal hace un sonido
// error: miAnimal.SonidoOrangutan(); // Error de compilación: 'Animal' no contiene una definición para 'SonidoOrangutan'

//Downcasting  Clase Padre a Clase Hija 
Orangutan miOrangutan = (Orangutan)miAnimal; // Conversión explícita de Animal a Orangutan
miOrangutan.SonidoOrangutan();

//Upcasting Clase Hija a Clase Padre
Animal otroAnimal = new Animal();
//Orangutan otroOrangutan = (Orangutan)otroAnimal;
//otroOrangutan.SonidoOrangutan();

//Conversion por tipo de refencia
object obj = "Hola, Mundo!";
string cadena = obj as string; // Conversión segura de object a string
Console.WriteLine(cadena);



public class Animal
{
    //Atributos
    //Métodos
    public void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}
public class Orangutan : Animal
{
    public void SonidoOrangutan()
    {
               Console.WriteLine("AHAHAHAHA");
    }
}