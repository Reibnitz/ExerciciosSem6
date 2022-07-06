using Sem_6_Ex_2.Exceptions;

namespace Sem_6_Ex_2
{
    public class MensagensConsole
    {
        public static int EscolherOperacao()
        {
            Console.WriteLine("Semana 6 - Exercício 2 - Abstração calculadora\n");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.Write("\nEscolha a opção desejada: ");

            bool selecao = int.TryParse(Console.ReadLine(), out int output);
            if (!selecao || output > 4) throw new OpcaoInvalidaException();

            return output;
        }

        public static double DefinirValor()
        {
            Console.Write("Escolha o valor: ");
            bool selecao = int.TryParse(Console.ReadLine(), out int output);
            if (!selecao) throw new EntradaNulaException();

            return output;
        }

        public static void ExibirResultado(double resultado)
        {
            Console.WriteLine($"O resultado da operação é: {resultado}\n");
        }
    }
}
