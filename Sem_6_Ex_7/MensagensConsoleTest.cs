using Sem_6_Ex_2;
using Sem_6_Ex_2.Exceptions;
using Xunit;


namespace Sem_6_Ex_7
{
    public class MensagensConsoleTest
    {
        [Fact]
        public void ProcessarSelecaoDeOperacao_DeveriaProcessarComNumeroValido()
        {
            int esperado = 1;

            int obtido = MensagensConsole.ProcessarSelecaoDeOperacao("1");

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void ProcessarSelecaoDeOperacao_NaoDeveriaProcessarNumeroInvalido()
        {
            Assert.Throws<OpcaoNaoExistenteException>(
                () => MensagensConsole.ProcessarSelecaoDeOperacao("5")
            );
        }

        [Fact]
        public void ProcessarSelecaoDeOperacao_NaoDeveriaProcessarTexto()
        {
            Assert.Throws<EntradaInvalidaException>(
                () => MensagensConsole.ProcessarSelecaoDeOperacao("texto qualquer")
            );
        }

        [Theory]
        [InlineData("5.5")]
        [InlineData("5,5")]
        public void ProcessarSelecaoDeValor_DeveriaProcessarNumerosComPontoOuVirgula(string inputUsuario)
        {
            double esperado = 5.5;
            double obtido = MensagensConsole.ProcessarSelecaoDeValor(inputUsuario);

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void ProcessarSelecaoDeValor_DeveriaProcessarNumerosInteiros()
        {
            double esperado = 10;
            double obtido = MensagensConsole.ProcessarSelecaoDeValor("10");

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void ProcessarSelecaoDeValor_NaoDeveriaProcessarTexto()
        {
            Assert.Throws<EntradaInvalidaException>(
                () => MensagensConsole.ProcessarSelecaoDeValor("texto qualquer")
            );
        }
    }
}
