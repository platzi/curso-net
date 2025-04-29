namespace Operaciones
{
    public static class Calculadora
    {
        public static string Suma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return ResultadoOperacion(resultado);
        }

        public static string Resta(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return ResultadoOperacion(resultado);
        }

        public static string Multiplicacion(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return ResultadoOperacion(resultado);
        }

        public static string Division(int numero1, int numero2)
        {
            if (numero2 == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
                
            int resultado = numero1 / numero2;
            return ResultadoOperacion(resultado);
        }

        private static string ResultadoOperacion(int resultado)
        {
            return $"El resultado de la operación es: {resultado}";
        }
    }
}