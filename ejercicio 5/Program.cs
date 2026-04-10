Console.Write("Ingrese la cantidad de números (n): ");
int n = int.Parse(Console.ReadLine());

int[] numeros = new int[n];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Ingrese valor para posición " + i + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}

int mayor = numeros[0];

for (int i = 1; i < numeros.Length; i++)
{
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
}

Console.WriteLine("Mayor: " + mayor);