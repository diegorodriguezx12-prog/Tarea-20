Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Valor " + i + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Positivos:");
for (int i = 0; i < n; i++)
{
    if (numeros[i] > 0) { Console.WriteLine(numeros[i]); }
}