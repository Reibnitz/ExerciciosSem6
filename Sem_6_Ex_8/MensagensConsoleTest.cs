using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sem_6_Ex_3;
using Sem_6_Ex_3.Exceptions;
using Xunit;

namespace Sem_6_Ex_8
{
    public class MensagensConsoleTest
    {
        [Fact]
        public void ProcessarSelecaoAluno_DeveriaProcessarComNumeroValido()
        {
            //Arrange
            int esperado = 3;

            //Act
            int obtido = MensagensConsole.ProcessarSelecaoAluno("3", 5);

            //Assert
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void ProcessarSelecaoAluno_NaoDeveriaProcessarComNumeroInvalido()
        {
            Assert.Throws<OpcaoInvalidaException>(
                () => MensagensConsole.ProcessarSelecaoAluno("6", 5)
            );
        }

        [Fact]
        public void ProcessarSelecaoAluno_NaoDeveriaProcessarComTexto()
        {
            Assert.Throws<OpcaoInvalidaException>(
                () => MensagensConsole.ProcessarSelecaoAluno("texto", 5)
            );
        }
    }
}
