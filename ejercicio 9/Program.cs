Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Valor " + i + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.Write("Posición a modificar: ");
int pos = int.Parse(Console.ReadLine());
Console.Write("Nuevo valor: ");
numeros[pos] = int.Parse(Console.ReadLine());