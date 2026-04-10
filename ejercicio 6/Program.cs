Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Valor " + i + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}

int menor = numeros[0];
for (int i = 1; i < numeros.Length; i++)
{
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}
Console.WriteLine("Menor: " + menor);