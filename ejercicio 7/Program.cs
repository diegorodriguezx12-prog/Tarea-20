Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];
int pares = 0, impares = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Valor " + i + ": ");
    numeros[i] = int.Parse(Console.ReadLine());

    if (numeros[i] % 2 == 0) { pares++; }
    else { impares++; }
}
Console.WriteLine("Pares: " + pares);
Console.WriteLine("Impares: " + impares);