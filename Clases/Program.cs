using Operaciones;

Operaciones.Calculadora calculadora = new Operaciones.Calculadora();

string resultadoSuma = calculadora.Suma(5, 3);
Console.WriteLine($"La suma de 5 y 3 es: {resultadoSuma}");

string resultadoResta = calculadora.ResultadoOperacion(5);

Console.WriteLine($"La resta de 5 y 3 es: {resultadoResta}");