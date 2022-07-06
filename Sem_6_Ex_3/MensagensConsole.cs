using Sem_6_Ex_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            bool resposta = int.TryParse(Console.ReadLine(), out int alunoSelecionado);
            if (!resposta) throw new Exception("O valor selecionado é inválido");
            if (alunoSelecionado > listaDeAlunos.Count) throw new Exception($"Aluno {alunoSelecionado} não existe");

            return alunoSelecionado - 1;
        }

        internal static void ListarDisciplinas(IAluno alunoSelecionado)
        {
            Console.WriteLine("\n----- Lista de disciplinas matriculadas -----\n");
            int i = 1;
            foreach (var d in alunoSelecionado.ListaDeDisciplinas)
            {
                Console.WriteLine($"{i}- {d.Nome}");
                i++;
            }
        }

        internal static IAvaliacao CriarAvaliacao(IAluno alunoSelecionado)
        {
            Console.WriteLine("\n----- Inserir avaliação -----\n");
            ListarDisciplinas(alunoSelecionado);

            Console.Write("Selecione a disciplina: ");
            bool respostaDisciplina = int.TryParse(Console.ReadLine(), out int disciplinaSelecionada);
            if (!respostaDisciplina)
                throw new Exception("O valor selecionado é inválido");
            IDisciplina disciplina = alunoSelecionado.ListaDeDisciplinas[disciplinaSelecionada - 1];

            Console.Write($"Selecione o número da avaliação (1 a {disciplina.QuantidadeAvaliacoes}): ");
            bool respostaNumeroAvaliacao = int.TryParse(Console.ReadLine(), out int numeroAvaliacao);
            if (!respostaNumeroAvaliacao)
                throw new Exception("O valor selecionado é inválido");

            Console.Write("Digite a nota desejada: ");
            bool respostaNota = double.TryParse(Console.ReadLine(), out double notaSelecionada);
            if (!respostaNumeroAvaliacao)
                throw new Exception("O valor selecionado é inválido");

            return Factory.CriarAvaliacao(disciplina, numeroAvaliacao, notaSelecionada);
        }

        public static void ListarBoletim(IAluno alunoSelecionado)
        {
            Console.WriteLine(alunoSelecionado.Boletim);
            //foreach (var d in alunoSelecionado.ListaDeDisciplinas)
            //{
            //    Console.WriteLine($"\nDisciplina: {d.Nome}");
            //    Console.Write("Notas provas: ");

            //    IEnumerable<IAvaliacao> avaliacoes = alunoSelecionado.Boletim.Where(b => b.Disciplina.Nome == d.Nome);

            //    double soma = 0;
            //    foreach (var a in avaliacoes)
            //    {
            //        Console.Write($"{a.Nota}, ");
            //        soma += a.Nota;
            //    }

            //    Console.WriteLine($"Média: {soma / avaliacoes.Count()}");

            //}
        }

        public static EOperacao SelecionarOpcao()
        {
            Console.WriteLine("\n----- Lista de operações -----\n");
            Console.WriteLine("1- Listar boletim");
            Console.WriteLine("2- Listar disciplinas matriculadas");
            Console.WriteLine("3- Inserir avaliação");

            Console.Write("\nSelecione a operação desejada: ");
            bool resposta = int.TryParse(Console.ReadLine(), out int opcaoSelecionada);
            if (!resposta || opcaoSelecionada > 3) throw new Exception($"A opção número {opcaoSelecionada} é inválida");

            return (EOperacao)opcaoSelecionada;
        }
    }
}
