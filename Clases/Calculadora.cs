namespace Operaciones
{
    private class Calculadora
    {
        public string Suma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return ResultadoOperacion(resultado);
        }

        public string Resta(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return ResultadoOperacion(resultado);
        }

        public string Multiplicacion(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return ResultadoOperacion(resultado);
        }

        public string Division(int numero1, int numero2)
        {
            if (numero2 == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
                
            int resultado = numero1 / numero2;
            return ResultadoOperacion(resultado);
        }

        private string ResultadoOperacion(int resultado)
        {
            return $"El resultado de la operación es: {resultado}";
        }
    }
}