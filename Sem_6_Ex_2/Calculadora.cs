using Sem_6_Ex_2.Exceptions;

namespace Sem_6_Ex_2
{
    internal class Calculadora
    {
        internal static double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        internal static double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        internal static double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        internal static double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0) throw new CalculoInvalidoException();
            return valor1 / valor2;
        }
    }
}
