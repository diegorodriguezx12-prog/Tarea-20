Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
int[] original = new int[n];
int[] copia = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Valor " + i + ": ");
    original[i] = int.Parse(Console.ReadLine());
    copia[i] = original[i];
}