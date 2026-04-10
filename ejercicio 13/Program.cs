Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Valor " + i + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Pares:");
for (int i = 0; i < n; i++) { if (numeros[i] % 2 == 0) Console.Write(numeros[i] + " "); }

Console.WriteLine("\nImpares:");
for (int i = 0; i < n; i++) { if (numeros[i] % 2 != 0) Console.Write(numeros[i] + " "); }