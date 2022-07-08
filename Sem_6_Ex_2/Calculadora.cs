using Sem_6_Ex_2.Exceptions;

namespace Sem_6_Ex_2
{
    public class Calculadora
    {
        public static double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public static double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public static double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public static double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0) throw new CalculoInvalidoException();
            return valor1 / valor2;
        }
    }
}
