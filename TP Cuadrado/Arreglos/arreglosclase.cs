//Arreglos
//Inicialización
int [] numeros = new int [3];

//Asignar valores a elementos

numeros[0] = 1;//n int numeros [3] [1,2,3]
numeros[1] = 2;
numeros[2] = 3;
// La posición de la memoria siempre empieza en 0, el primer elemento es posición 0
for (int i = 0; i<=2;i++)
{
    Console.WriteLine(numeros[i]);
}

//foreach es variante del for, solo que acá me da valores
//el foreach int me dice que cada elemento de cada posición son enteros
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
if (numeros[1]==2)
{
    Console.WriteLine("Es un dos");
}
//Obtener la longitud (el arreglo es una longitud vectorial)
Console.WriteLine(numeros.Length);

//Definicion implicita
int[] numeros2 = new int[10] { 4, 5, 6,8,9,1,2,3,7,11 };
char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
foreach (char vocal in vocales)
{
    Console.WriteLine(vocal);
}
bool[] estaos = new bool[3];
estaos[0] = true;
estaos[1] = false;
estaos[2] = false;

if (!estaos[0])
{
    Console.WriteLine("Aquí hay un verdadero");
}
//Ordenamiento de mayor a menor

Console.WriteLine("Arreglo desordenado");
foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}
Array.Sort(numeros2);
foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}

Array.Reverse(numeros2);
Console.WriteLine("Arreglo ordenado mayor a menor");
foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
} //Arreglo previamente ordenado de menor a mayor
//BUsqueda por valor
Console.WriteLine(Array.BinarySearch(numeros2,7));