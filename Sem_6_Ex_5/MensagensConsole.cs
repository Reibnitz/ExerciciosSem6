namespace Sem_6_Ex_5
{
    public class MensagensConsole
    {
        public static void ListarOperacoes()
        {
            Console.WriteLine("\n##################################################\n");
            Console.WriteLine("1- Criar novo compromisso");
            Console.WriteLine("2- Mostrar lista de compromissos");
            Console.WriteLine("3- Mostrar os próximos compromissos do dia");
        }

        public static Operacao EscolherOperacao()
        {
            Console.Write("\nEscolha a operação desejada: ");
            bool resposta = int.TryParse(Console.ReadLine(), out int operacaoEscolhida);
            if (!resposta || operacaoEscolhida > 3)
                throw new OpcaoInvalidaException();

            return (Operacao)operacaoEscolhida;
        }

        public static void CriarCompromisso(Agenda agenda)
        {
            string nome = DefinirNomeCompromisso();
            string descricao = DefinirDescricaoCompromisso();
            DateOnly data = DefinirDataCompromisso();
            TimeOnly horario = DefinirHorarioCompromisso();
            TimeSpan duracao = DefinirDuracaoCompromisso();

            agenda.CriarCompromisso(nome, descricao, data, horario, duracao);
        }

        private static string DefinirNomeCompromisso()
        {
            Console.Write("Nome do compromisso: ");
            string nome = Console.ReadLine();

            return nome;
        }

        private static string DefinirDescricaoCompromisso()
        {
            Console.Write("Descrição do compromisso: ");
            string descricao = Console.ReadLine();

            return descricao;
        }

        private static TimeSpan DefinirDuracaoCompromisso()
        {
            Console.Write("Duração (horas): ");
            bool respostaHoras = int.TryParse(Console.ReadLine(), out int duracaoHoras);
            if (!respostaHoras)
                throw new OpcaoInvalidaException();

            Console.Write("Duração (minutos): ");
            bool respostaMinutos = int.TryParse(Console.ReadLine(), out int duracaoMinutos);
            if (!respostaMinutos)
                throw new OpcaoInvalidaException();

            TimeSpan duracao = new(duracaoHoras, duracaoMinutos, 0);

            if ((duracaoHoras == 4 && duracaoMinutos > 0) || duracaoHoras > 4)
                throw new DuracaoInvalidaException(duracao);

            return duracao;
        }

        private static TimeOnly DefinirHorarioCompromisso()
        {
            Console.Write("Hora: ");
            bool respostaHora = int.TryParse(Console.ReadLine(), out int hora);
            if (!respostaHora)
                throw new OpcaoInvalidaException();

            Console.Write("Minutos: ");
            bool respostaMinutos = int.TryParse(Console.ReadLine(), out int minuto);
            if (!respostaMinutos)
                throw new OpcaoInvalidaException();

            TimeOnly horario = new(hora, minuto);
            return horario;
        }

        private static DateOnly DefinirDataCompromisso()
        {
            Console.Write("Dia: ");
            bool respostaDia = int.TryParse(Console.ReadLine(), out int dia);
            if (!respostaDia)
                throw new OpcaoInvalidaException();
            Console.Write("Mês: ");
            bool respostaMes = int.TryParse(Console.ReadLine(), out int mes);
            if (!respostaMes)
                throw new OpcaoInvalidaException();
            Console.Write("Ano: ");
            bool respostaAno = int.TryParse(Console.ReadLine(), out int ano);
            if (!respostaAno)
                throw new OpcaoInvalidaException();

            DateOnly data = new(ano, mes, dia);
            return data;
        }
    }
}