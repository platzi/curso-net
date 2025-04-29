using System;

CalculatorService calculator = new CalculatorService();

Console.WriteLine("Suma: " + calculator.Add(5, 3));
Console.WriteLine("Resta: " + calculator.Subtract(5, 3));
Console.WriteLine("Multiplicación: " + calculator.Multiply(5, 3));
Console.WriteLine("División: " + calculator.Divide(5, 3));
