Console.WriteLine("Por favor ingresa tu nombre");
string nombre = Console.ReadLine();

foreach (char letra in nombre)
{
    Console.WriteLine(letra);
}

int contador = 10;
foreach (int i in Enumerable.Range(1, contador))
{
    Console.WriteLine($"Contador: {contador}");
    contador--;
}