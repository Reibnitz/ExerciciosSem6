using Sem_6_Ex_1;
using Sem_6_Ex_1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sem_6_Ex_6
{
    public class ContaTest
    {
        int numero;
        decimal saldo;
        decimal limiteDeSaque;
        bool ehOperacional;

        [Fact]
        public void VerificarOperacionalidade_DeveriaRetornarTrueQuandoAContaEhOperacional()
        {
            Conta conta = new(
                numero: 123,
                saldo: 123.4m,
                limiteDeSaque: 500.0m,
                ehOperacional: true
            );

            bool esperado = true;

            bool obtido = conta.VerificarOperacionalidade();

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void VerificarOperacionalidade_DeveriaLancarExceptionQuandoAContaNaoEhOperacional()
        {
            Conta conta = new(
                numero: 123,
                saldo: 123.4m,
                limiteDeSaque: 500,
                ehOperacional: false
            );

            Assert.Throws<ContaNaoOperacionalException>(
                () => conta.VerificarOperacionalidade()
            );
        }

        [Fact]
        public void Depositar_DeveriaDepositarValoresPositivos()
        {
            Conta conta = new(
                numero: 123,
                saldo: 1000,
                limiteDeSaque: 500,
                ehOperacional: true
            );

            decimal esperado = 1100;

            conta.Depositar(100);
            decimal obtido = conta.Saldo;

            Assert.Equal(esperado, obtido);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        public void Depositar_DeveriaDepositarValoresNegativosOuZero(decimal valor)
        {
            Conta conta = new(
                numero: 123,
                saldo: 1000,
                limiteDeSaque: 500,
                ehOperacional: true
            );

            Assert.Throws<ValorInvalidoException>(
                () => conta.Depositar(valor)
            );
        }

        [Fact]
        public void Sacar_DeveriaSacarValorValido()
        {
            Conta conta = new(
                numero: 123,
                saldo: 1000,
                limiteDeSaque: 500,
                ehOperacional: true
            );

            decimal esperado = 600;
            conta.Sacar(400);
            decimal obtido = conta.Saldo;

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void Sacar_NaoDeveriaSacarValorAcimaDoSaldo()
        {
            Conta conta = new(
                numero: 123,
                saldo: 100,
                limiteDeSaque: 500,
                ehOperacional: true
            );

            Assert.Throws<SaldoInsuficienteException>(
                () => conta.Sacar(200)
            );
        }

        [Fact]
        public void Sacar_NaoDeveriaSacarValorAcimaDoLimiteDeSaque()
        {
            Conta conta = new(
                numero: 123,
                saldo: 1000,
                limiteDeSaque: 500,
                ehOperacional: true
            );

            Assert.Throws<LimiteInsuficienteException>(
                () => conta.Sacar(600)
            );
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-100)]
        public void Sacar_NaoDeveriaSacarValorNegativoOuIgualAZero(decimal valor)
        {
            Conta conta = new(
                numero: 123,
                saldo: 1000,
                limiteDeSaque: 500,
                ehOperacional: true
            );

            Assert.Throws<ValorInvalidoException>(
                () => conta.Sacar(valor)
            );
        }

        
    }
}
