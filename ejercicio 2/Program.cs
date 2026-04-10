Console.Write("Ingrese la cantidad de números (n): ");
int n = int.Parse(Console.ReadLine());

int[] numeros = new int[n];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Ingrese el valor para la posición " + i + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Mostrando los datos en orden inverso:");

for (int i = numeros.Length - 1; i >= 0; i--)
{
    Console.WriteLine("Posición: " + i + "  Valor: " + numeros[i]);
}