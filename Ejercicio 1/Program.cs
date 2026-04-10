Console.WriteLine("Ingrese la cantidad de números que desea ingresar");
int cantidad = int.Parse(Console.ReadLine());

int[] numeros = new int[cantidad];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Ingrese el valor para la posición " + i + ": ");
    numeros[i] = int.Parse(Console.ReadLine());
}
