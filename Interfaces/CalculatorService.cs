using Operations;
public class CalculatorService : ICalculatorService
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        Console.WriteLine("En una implementación de método resta diferente");
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        int resultado = a * b;
        return resultado;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return (double)a / b;
    }
}