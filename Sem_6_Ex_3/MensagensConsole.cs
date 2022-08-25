using Sem_6_Ex_3.Exceptions;
using Sem_6_Ex_3.Interfaces;

namespace Sem_6_Ex_3
{
    public class MensagensConsole
    {
        public static void ListarAlunos(List<IAluno> listaDeAlunos)
        {
            Console.WriteLine("----- Lista de alunos -----\n");
            foreach (var a in listaDeAlunos)
            {
                Console.WriteLine($"{listaDeAlunos.IndexOf(a) + 1} - {a.Nome}");
            }
        }

        public static int SelecionarAluno(List<IAluno> listaDeAlunos)
        {
            Console.Write("\nSelecione um aluno: ");
            int alunoSelecionado = ProcessarSelecaoAluno(Console.ReadLine(), listaDeAlunos.Count);

            return alunoSelecionado - 1;
        }

        public static int ProcessarSelecaoAluno(string inputUsuario, int numeroDeAlunos)
        {
            bool resposta = int.TryParse(inputUsuario, out int alunoSelecionado);
            if (!resposta) throw new OpcaoInvalidaException();
            if (alunoSelecionado > numeroDeAlunos) throw new OpcaoInvalidaException($"Aluno {alunoSelecionado} não existe");

            return alunoSelecionado;
        }

        internal static void ListarDisciplinas(IAluno alunoSelecionado, bool chamadaInterna = false)
        {
            if (!chamadaInterna)
                Console.WriteLine("\n----- Lista de disciplinas matriculadas -----\n");
            int i = 1;
            foreach (var d in alunoSelecionado.ListaDeDisciplinas)
            {
                Console.WriteLine($"{i}- {d.Nome}");
                i++;
            }
        }

        public static IDisciplina SelecionarDisciplina(IAluno alunoSelecionado)
        {
            Console.WriteLine("\n----- Inserir avaliação -----\n");
            ListarDisciplinas(alunoSelecionado, chamadaInterna: true);
            Console.Write("Selecione a disciplina: ");

            bool respostaDisciplina = int.TryParse(Console.ReadLine(), out int disciplinaSelecionada);
            if (!respostaDisciplina)
                throw new OpcaoInvalidaException();

            return alunoSelecionado.ListaDeDisciplinas[disciplinaSelecionada - 1];
        }

        public static int SelecionarAvaliacao(IDisciplina disciplina)
        {
            Console.Write($"Selecione o número da avaliação (1 a {disciplina.QuantidadeAvaliacoes}): ");
            bool respostaNumeroAvaliacao = int.TryParse(Console.ReadLine(), out int numeroAvaliacao);
            if (!respostaNumeroAvaliacao)
                throw new OpcaoInvalidaException();

            return numeroAvaliacao;
        }

        public static double SelecionarNota()
        {
            Console.Write("Digite a nota desejada: ");
            bool respostaNota = double.TryParse(Console.ReadLine(), out double notaSelecionada);
            if (!respostaNota)
                throw new OpcaoInvalidaException();

            return notaSelecionada;
        }

        public static void ListarBoletim(IAluno alunoSelecionado)
        {
            if (alunoSelecionado.Boletim.Count() == 0)
                throw new ListaDisciplinaVaziaException(alunoSelecionado);

            foreach (var d in alunoSelecionado.ListaDeDisciplinas)
            {
                Console.WriteLine($"\nDisciplina: {d.Nome}");

                IEnumerable<IAvaliacao> avaliacoes = alunoSelecionado.Boletim.Where(b => b.Disciplina.Nome == d.Nome);

                if (avaliacoes.Count() == 0)
                {
                    Console.WriteLine("Nenhuma prova foi realizada nessa disciplina até o momento");
                }
                else
                {
                    Console.Write("Notas provas: ");
                    double soma = 0;
                    foreach (var a in avaliacoes)
                    {
                        if (avaliacoes.ElementAt(avaliacoes.Count() - 1) == a)
                            Console.Write($"{a.Nota}");
                        else
                            Console.Write($"{a.Nota}, ");

                        soma += a.Nota;
                    }

                    Console.WriteLine($"\nMédia: {soma / avaliacoes.Count()}");
                }
            }
        }

        public static EOperacao SelecionarOpcao()
        {
            Console.WriteLine("\n----- Lista de operações -----\n");
            Console.WriteLine("1- Listar boletim");
            Console.WriteLine("2- Listar disciplinas matriculadas");
            Console.WriteLine("3- Inserir avaliação");

            Console.Write("\nSelecione a operação desejada: ");
            bool resposta = int.TryParse(Console.ReadLine(), out int opcaoSelecionada);
            if (!resposta || opcaoSelecionada > 3) throw new OpcaoInvalidaException();

            return (EOperacao)opcaoSelecionada;
        }
    }
}
