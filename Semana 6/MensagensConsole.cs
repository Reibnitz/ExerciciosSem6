namespace Sem_6_Ex_1
{
    public class MensagensConsole
    {
        public static void Iniciar()
        {
            Console.WriteLine($"Exercício 1 - Abstração caixa de banco\n");
        }

        public static int SelecionarConta(List<Conta> listaDeContas)
        {
            foreach (Conta c in listaDeContas)
            {
                Console.WriteLine($"{listaDeContas.IndexOf(c) + 1}- CC {c.Numero}");
            }

            Console.Write("\nSelecione uma conta (1 a 5): ");
            bool resultadoSelecaoConta = int.TryParse(Console.ReadLine(), out int contaSelecionada);

            return contaSelecionada - 1;
        }

        public static int SelecionarOperacao()
        {
            Console.WriteLine("1- Exibir saldo");
            Console.WriteLine("2- Sacar");
            Console.WriteLine("3- Depositar");

            bool resultadoSelecaoOperacao = int.TryParse(Console.ReadLine(), out int operacaoSelecionada);

            return operacaoSelecionada;
        }

        public static decimal SelecionarValor(int operacaoEscolhida)
        {
            if (operacaoEscolhida == 1) return 0;
            if (operacaoEscolhida == 2)
                Console.Write("Defina o valor a ser sacado: ");
            if (operacaoEscolhida == 3)
                Console.WriteLine("Defina o valor a ser depositado: ");

            bool resultadoSelecaoValor = decimal.TryParse(Console.ReadLine(), out decimal valorSelecionado);

            return valorSelecionado;
        }
    }
}
