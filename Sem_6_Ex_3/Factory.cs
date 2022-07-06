using Sem_6_Ex_3.Exceptions;
using Sem_6_Ex_3.Interfaces;
using Sem_6_Ex_3.Models;

namespace Sem_6_Ex_3
{
    public class Factory
    {
        public static IAluno CriarAluno(string nome, int numeroDeMatricula, List<IDisciplina> listaDeDisciplina)
        {
            return new Aluno(nome, numeroDeMatricula, listaDeDisciplina);
        }

        public static IDisciplina CriarDisciplina(string nome, int quantidadeDeAvaliacoes)
        {
            return new Disciplina(nome, quantidadeDeAvaliacoes);
        }

        public static IAvaliacao CriarAvaliacao(IDisciplina disciplina, int numeroAvaliacao, double nota)
        {
            if (numeroAvaliacao > disciplina.QuantidadeAvaliacoes) throw new AvaliacaoInvalidaException(numeroAvaliacao, disciplina.QuantidadeAvaliacoes);
            if (nota > 10 || nota < 0) throw new NotaInvalidaException(nota);

            return new Avaliacao(disciplina, numeroAvaliacao, nota);
        }
    }
}
