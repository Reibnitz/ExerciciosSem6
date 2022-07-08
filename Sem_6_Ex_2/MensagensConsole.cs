using Sem_6_Ex_2.Exceptions;

namespace Sem_6_Ex_2
{
    public class MensagensConsole
    {
        public static void ExibirOperacoes()
        {
            Console.WriteLine("Semana 6 - Exercício 2 - Abstração calculadora\n");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
        }

        public static int EscolherOperacao()
        {
            Console.Write("\nEscolha a opção desejada: ");

            string inputUsuario = Console.ReadLine();
            int valorSelecionado = ProcessarSelecaoDeOperacao(inputUsuario);

            return valorSelecionado;
        }

        public static int ProcessarSelecaoDeOperacao(string inputUsuario)
        {
            bool selecao = int.TryParse(inputUsuario, out int output);
            if (!selecao) throw new EntradaInvalidaException();
            if (output > 4) throw new OpcaoNaoExistenteException();

            return output;
        }

        public static double DefinirValor()
        {
            Console.Write("Escolha o valor: ");
            string inputUsuario = Console.ReadLine();
            double valorSelecionado = ProcessarSelecaoDeValor(inputUsuario);

            return valorSelecionado;
        }

        public static double ProcessarSelecaoDeValor(string inputUsuario)
        {
            if (inputUsuario.Contains("."))
            {
                inputUsuario = inputUsuario.Replace(".", ",");
            }

            bool selecao = double.TryParse(inputUsuario, out double output);
            if (!selecao) throw new EntradaInvalidaException();

            return output;
        }

        public static void ExibirResultado(double resultado)
        {
            Console.WriteLine($"O resultado da operação é: {resultado}\n");
        }
    }
}
