namespace Operaciones
{
    public class Calculadora
    {
        public int Suma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        public int Resta(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        public int Multiplicacion(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        public int Division(int numero1, int numero2)
        {
            if (numero2 == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
                
            int resultado = numero1 / numero2;
            return resultado;
        }
    }
}