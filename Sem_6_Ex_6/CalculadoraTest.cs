using Sem_6_Ex_2;
using Sem_6_Ex_2.Exceptions;
using Xunit;

namespace Sem_6_Ex_6
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar_DeveriaSomar()
        {
            // Arrange
            double esperado = 5;

            // Act
            double obtido = Calculadora.Somar(2, 3);

            // Assert

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void Subtrair_DeveriaSubtrair()
        {
            double esperado = 1;

            double obtido = Calculadora.Subtrair(3, 2);

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void Multiplicar_DeveriaMultiplicar()
        {
            double esperado = 3;

            double obtido = Calculadora.Multiplicar(2, 1.5);

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void Dividir_DeveriaDividir()
        {
            double esperado = 1.5;

            double obtido = Calculadora.Dividir(3, 2);

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void Dividir_NaoDeveriaDividirPorZero()
        {
            Assert.Throws<CalculoInvalidoException>(
                () => Calculadora.Dividir(1, 0)
            );
        }
    }
}
