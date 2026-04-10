Console.Write("Ingrese la cantidad de números (n): ");
int n = int.Parse(Console.ReadLine());

int[] numeros = new int[n];
int suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Ingrese el valor para la posición " + i + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i]; 
}

Console.WriteLine("\nLa suma total es: " + suma);