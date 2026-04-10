Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Valor " + i + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < n - 1; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (numeros[i] > numeros[j])
        {
            int temp = numeros[i];
            numeros[i] = numeros[j];
            numeros[j] = temp;
        }
    }
}