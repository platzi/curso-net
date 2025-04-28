
int Suma(int numero1, int numero2)
{
    Console.WriteLine($"La suma de {numero1} + {numero2} es: {numero1 + numero2}");
    int resultado = numero1 + numero2;
    return resultado;
}

int numeroResultado = Suma(5, 10);

Console.WriteLine($"El resultado de la suma es: {numeroResultado}");
//Suma(5, 10);
