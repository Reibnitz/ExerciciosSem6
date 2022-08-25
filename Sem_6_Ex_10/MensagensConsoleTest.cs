using Sem_6_Ex_5;
using Sem_6_Ex_5.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sem_6_Ex_10
{
    public class MensagensConsoleTest
    {
        [Theory]
        [InlineData(-1,1,1)]
        [InlineData(1,-1,1)]
        [InlineData(1,1,-1)]
        public void GerarData_NaoDeveriaCriarComDataInvalida(int ano, int mes, int dia)
        {
            Assert.Throws<DataInvalidaException>(
                () => MensagensConsole.GerarData(ano, mes, dia)
            );
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(25, 1)]
        [InlineData(1, -1)]
        [InlineData(1, 61)]
        public void GerarHorario_NaoDeveriaCriarComHorarioInvalido(int hora, int minuto)
        {
            Assert.Throws<HorarioInvalidoException>(
                () => MensagensConsole.GerarHorario(hora, minuto)
            );
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(25, 1)]
        [InlineData(1, -1)]
        [InlineData(1, 61)]
        public void GerarDuracao_NaoDeveriaCriarComHorarioInvalido(int hora, int minuto)
        {
            Assert.Throws<DuracaoInvalidaException>(
                () => MensagensConsole.GerarDuracao(hora, minuto)
            );
        }

        [Theory]
        [InlineData(4, 1)]
        [InlineData(5, 0)]
        public void GerarDuracao_NaoDeveriaCriarDuracaoMaiorQue4Horas(int hora, int minuto)
        {
            Assert.Throws<DuracaoInvalidaException>(
                () => MensagensConsole.GerarDuracao(hora, minuto)
            );
        }
    }
}
