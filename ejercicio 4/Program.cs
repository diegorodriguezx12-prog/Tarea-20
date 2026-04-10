Console.Write("Ingrese la cantidad de números (n): ");
int n = int.Parse(Console.ReadLine());

double[] numeros = new double[n];
double sumaTotal = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Ingrese el valor para la posición " + i + ": ");
    numeros[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < numeros.Length; i++)
{
    sumaTotal += numeros[i];
}

double promedio = sumaTotal / n;

Console.WriteLine("La suma total es: " + sumaTotal);
Console.WriteLine("El promedio es: " + promedio);