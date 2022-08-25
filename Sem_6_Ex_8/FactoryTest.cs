using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem_6_Ex_3;
using Sem_6_Ex_3.Exceptions;
using Sem_6_Ex_3.Interfaces;
using Sem_6_Ex_3.Models;
using Xunit;

namespace Sem_6_Ex_8
{
    public class FactoryTest
    {
        private Disciplina _disciplina = new(nome: "nomeDisciplina", quantidadeAvaliacoes: 3);

        [Theory]
        [InlineData(0)]
        [InlineData(2.5)]
        [InlineData(10)]
        public void CriarAvaliacao_DeveriaCriarComNotaValida(double nota)
        {
            //Arrange
            double notaEsperada = nota;

            //Act
            IAvaliacao avaliacao = Factory.CriarAvaliacao(disciplina: _disciplina, numeroAvaliacao: 1, nota: nota);

            //Assert
            Assert.Equal(notaEsperada, avaliacao.Nota);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void CriarAvaliacao_DeveriaCriarComAvaliacaoValida(int numeroAvaliacao)
        {
            //Arrange
            int avaliacaoEsperada = numeroAvaliacao;

            //Act
            IAvaliacao avaliacao = Factory.CriarAvaliacao(disciplina: _disciplina, numeroAvaliacao: numeroAvaliacao, nota: 5);

            //Assert
            Assert.Equal(avaliacaoEsperada, avaliacao.NumeroAvaliacao);
        }

        [Theory]
        [InlineData(11)]
        [InlineData(-1)]
        public void CriarAvaliacao_NaoDeveriaCriarComNotaInvalida(int nota)
        {
            Assert.Throws<NotaInvalidaException>(
                () => Factory.CriarAvaliacao(disciplina: _disciplina, numeroAvaliacao: 1, nota: nota)
            );
        }

        [Theory]
        [InlineData(4)]
        [InlineData(-1)]
        public void CriarAvaliacao_NaoDeveriaCriarComNumeroAvaliacaoInvalida(int numeroAvaliacao)
        {
            Assert.Throws<AvaliacaoInvalidaException>(
                () => Factory.CriarAvaliacao(disciplina: _disciplina, numeroAvaliacao: numeroAvaliacao, nota: 5)
            );
        }
    }
}
