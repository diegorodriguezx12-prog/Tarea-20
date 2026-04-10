Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Valor " + i + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.Write("Valor a buscar: ");
int buscar = int.Parse(Console.ReadLine());
int repeticiones = 0;
bool encontrado = false;

for (int i = 0; i < n; i++)
{
    if (numeros[i] == buscar)
    {
        encontrado = true;
        repeticiones++;
    }
}
Console.WriteLine("¿Encontrado?: " + encontrado);
Console.WriteLine("Repeticiones: " + repeticiones);